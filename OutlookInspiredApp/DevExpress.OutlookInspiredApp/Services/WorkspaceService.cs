namespace DevExpress.DevAV.Services {
    using System.Collections.Generic;

    public interface IWorkspaceService {
        void SetupDefaultWorkspace();
        void SaveWorkspace(string workspaceName);
        void RestoreWorkspace(string workspaceName);
        void ResetWorkspace(string workspaceName);
    }
    class WorkspaceService : IWorkspaceService {
        ISupportModuleLayout supportModuleLayout;
        static string DefaultWorkspaceLayout;
        static IDictionary<string, string> layouts;
        public WorkspaceService(ISupportModuleLayout supportModuleLayout) {
            this.supportModuleLayout = supportModuleLayout;
        }
        public void SetupDefaultWorkspace() {
            if(layouts == null)
                layouts = new Dictionary<string, string>();
            DefaultWorkspaceLayout = StoreCore();
        }
        public void SaveWorkspace(string workspaceName) {
            layouts[workspaceName] = StoreCore();
        }
        public void RestoreWorkspace(string workspaceName) {
            string layoutStr;
            if(!layouts.TryGetValue(workspaceName, out layoutStr))
                layoutStr = DefaultWorkspaceLayout;
            RestoreCore(layoutStr);
        }
        public void ResetWorkspace(string workspaceName) {
            layouts.Remove(workspaceName);
            RestoreCore(DefaultWorkspaceLayout);
        }
        string StoreCore() {
            using(var ms = new System.IO.MemoryStream()) {
                supportModuleLayout.SaveLayoutToStream(ms);
                return System.Convert.ToBase64String(ms.ToArray());
            }
        }
        void RestoreCore(string layoutStr) {
            if(string.IsNullOrEmpty(layoutStr)) return;
            using(var ms = new System.IO.MemoryStream(System.Convert.FromBase64String(layoutStr)))
                supportModuleLayout.RestoreLayoutFromStream(ms);
        }
    }
}