using DevExpress.Internal;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;

namespace DevExpress.DemoData
{
    [DbConfigurationType(typeof(DemoDbContextConfiguration))]
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(string dbName) : base(CreateConnection(dbName), true)
        {
        }

        public DemoDbContext(string nameOrConnectionString, bool token) : base(nameOrConnectionString)
        {
        }

        private static DbConnection CreateConnection(string dbName)
        {
            string file = DataDirectoryHelper.GetFile(dbName, "Data");
            try
            {
                FileAttributes attributes = File.GetAttributes(file);
                if (attributes.HasFlag((Enum)FileAttributes.ReadOnly))
                    File.SetAttributes(file, attributes & ~FileAttributes.ReadOnly);
            }
            catch
            {
            }
            SQLiteConnection sqLiteConnection = new SQLiteConnection();
            sqLiteConnection.ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = file
            }.ConnectionString;
            return (DbConnection)sqLiteConnection;
        }

        public static bool IsWebModel { get; set; }
    }
}

