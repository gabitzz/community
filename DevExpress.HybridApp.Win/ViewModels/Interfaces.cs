﻿using DevExpress.Utils.Menu;

namespace DevExpress.DevAV {
    public enum ModuleType {
        Unknown,

        MemberView,
        MemberEdit,
        TeamsPrint,
        MemberMailMerge,
        Teams,

        CustomersFilterPane,
        CustomersPeek,
        CustomerEditableView,
        CustomersModule,
        CustomerDetails,


        Messages,
        Todos,
        EditTodo,
        TodoPrint,

      
        Portal,
        PortalEditableView,

        Sales,
        SalesPrint,
        OrderView,
        Opportunities,
        EditNotes,
        Notes,

        Meal

    }
    public interface IMainModule : IPeekModulesHost,
    ISupportModuleLayout, ISupportTransitions, IDXMenuManagerProvider {
    }
    public interface ISupportTransitions {
        void StartTransition(bool effective);
        void EndTransition(bool effective);
    }
    public interface ISupportModuleLayout {
        void SaveLayoutToStream(System.IO.MemoryStream ms);
        void RestoreLayoutFromStream(System.IO.MemoryStream ms);
    }
    public interface IPeekModulesHost {
        bool IsDocked(ModuleType type);
        void DockModule(ModuleType moduleType);
        void ShowPeek(ModuleType moduleType);
    }
}
