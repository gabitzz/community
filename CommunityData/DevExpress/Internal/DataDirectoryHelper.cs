namespace DevExpress.Internal
{
    using Microsoft.Win32;
    using System;
    using System.Deployment.Application;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Threading;
    using System.Windows.Interop;

    public class DataDirectoryHelper
    {
        private static bool? _isClickOnce = new bool?();
        public const string DataFolderName = "Data";

        public static bool IsClickOnce
        {
            get
            {
                if (!DataDirectoryHelper._isClickOnce.HasValue)
                    DataDirectoryHelper._isClickOnce = new bool?(!BrowserInteropHelper.IsBrowserHosted && ApplicationDeployment.IsNetworkDeployed);
                return DataDirectoryHelper._isClickOnce.Value;
            }
        }

        public static string LocalPrefix { get; set; }

        public static string DataPath { get; set; }

        public static string GetDataDirectory()
        {
            if (!DataDirectoryHelper.IsClickOnce)
                return DataDirectoryHelper.GetEntryAssemblyDirectory();
            return ApplicationDeployment.CurrentDeployment.DataDirectory;
        }

        public static string GetFile(string fileName, string directoryName)
        {
            if (DataDirectoryHelper.DataPath != null)
                return Path.Combine(DataDirectoryHelper.DataPath, fileName);
            string dataDirectory = DataDirectoryHelper.GetDataDirectory();
            if (dataDirectory == null)
                return (string)null;
            string fullPath = Path.GetFullPath(dataDirectory);
            for (int index = 0; index < 9; ++index)
            {
                string path = fullPath + "\\" + directoryName + "\\" + fileName;
                try
                {
                    if (!File.Exists(path))
                    {
                        if (!Directory.Exists(path))
                            goto label_10;
                    }
                    return path;
                }
                catch
                {
                }
                label_10:
                fullPath += "\\..";
            }
            throw new FileNotFoundException(string.Format("{0} not found. ({1})", (object)fileName, (object)fullPath));
        }

        public static string GetDirectory(string directoryName)
        {
            string dataDirectory = DataDirectoryHelper.GetDataDirectory();
            if (dataDirectory == null)
                return (string)null;
            string fullPath = Path.GetFullPath(dataDirectory);
            for (int index = 0; index < 9; ++index)
            {
                string path = fullPath + "\\" + directoryName;
                try
                {
                    if (Directory.Exists(path))
                        return path;
                }
                catch
                {
                }
                fullPath += "\\..";
            }
            throw new DirectoryNotFoundException(directoryName + " not found");
        }

        public static void SetWebBrowserMode()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true) ?? Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION");
                if (registryKey == null)
                    return;
                registryKey.SetValue(Path.GetFileName(Process.GetCurrentProcess().ProcessName + ".exe"), (object)0, RegistryValueKind.DWord);
            }
            catch
            {
            }
        }

        public static string GetFileLocalCopy(string fileName, string directoryName)
        {
            if (string.IsNullOrEmpty(DataDirectoryHelper.LocalPrefix))
                throw new InvalidOperationException();
            string path2 = DataDirectoryHelper.LocalPrefix + fileName;
            string file = DataDirectoryHelper.GetFile(fileName, directoryName);
            string str = Path.Combine(Path.GetDirectoryName(file), path2);
            if (File.Exists(str))
                return str;
            File.Copy(file, str);
            FileAttributes attributes = File.GetAttributes(str);
            if ((attributes & FileAttributes.ReadOnly) != (FileAttributes)0)
                File.SetAttributes(str, attributes & ~FileAttributes.ReadOnly);
            return str;
        }

        public static IDisposable SingleInstanceApplicationGuard(string applicationName, out bool exit)
        {
            Mutex mutex = new Mutex(true, applicationName + "15.2");
            if (mutex.WaitOne(0, false))
            {
                exit = false;
            }
            else
            {
                Process currentProcess = Process.GetCurrentProcess();
                foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
                {
                    if (process.Id != currentProcess.Id && process.MainWindowHandle != IntPtr.Zero)
                    {
                        DataDirectoryHelper.WinApiHelper.SetForegroundWindow(process.MainWindowHandle);
                        DataDirectoryHelper.WinApiHelper.RestoreWindowAsync(process.MainWindowHandle);
                        break;
                    }
                }
                exit = true;
            }
            return (IDisposable)mutex;
        }

        private static string GetEntryAssemblyDirectory()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly == (Assembly)null)
                return (string)null;
            return Path.GetDirectoryName(entryAssembly.Location);
        }

        private static class WinApiHelper
        {
            [SecuritySafeCritical]
            public static bool SetForegroundWindow(IntPtr hwnd)
            {
                return DataDirectoryHelper.WinApiHelper.Import.SetForegroundWindow(hwnd);
            }

            [SecuritySafeCritical]
            public static bool RestoreWindowAsync(IntPtr hwnd)
            {
                return DataDirectoryHelper.WinApiHelper.Import.ShowWindowAsync(hwnd, DataDirectoryHelper.WinApiHelper.IsMaxmimized(hwnd) ? 3 : 9);
            }

            [SecuritySafeCritical]
            public static bool IsMaxmimized(IntPtr hwnd)
            {
                DataDirectoryHelper.WinApiHelper.Import.WINDOWPLACEMENT lpwndpl = new DataDirectoryHelper.WinApiHelper.Import.WINDOWPLACEMENT();
                lpwndpl.length = Marshal.SizeOf((object)lpwndpl);
                if (!DataDirectoryHelper.WinApiHelper.Import.GetWindowPlacement(hwnd, ref lpwndpl))
                    return false;
                return lpwndpl.showCmd == DataDirectoryHelper.WinApiHelper.Import.ShowWindowCommands.ShowMaximized;
            }

            private static class Import
            {
                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool GetWindowPlacement(IntPtr hWnd, ref DataDirectoryHelper.WinApiHelper.Import.WINDOWPLACEMENT lpwndpl);

                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool SetForegroundWindow(IntPtr hWnd);

                [DllImport("user32.dll")]
                public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

                public struct WINDOWPLACEMENT
                {
                    public int length;
                    public int flags;
                    public DataDirectoryHelper.WinApiHelper.Import.ShowWindowCommands showCmd;
                    public Point ptMinPosition;
                    public Point ptMaxPosition;
                    public Rectangle rcNormalPosition;
                }

                public enum ShowWindowCommands
                {
                    Hide,
                    Normal,
                    ShowMinimized,
                    ShowMaximized,
                    ShowNoActivate,
                    Show,
                    Minimize,
                    ShowMinNoActive,
                    ShowNA,
                    Restore,
                    ShowDefault,
                    ForceMinimize,
                }
            }
        }
    }
}

