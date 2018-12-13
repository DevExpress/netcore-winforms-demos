namespace DevExpress.DevAV.Services {
    public interface IPeekModulesHostingService {
        bool IsDocked(ModuleType moduleType);
        void DockModule(ModuleType moduleType);
        void UndockModule(ModuleType moduleType);
        void ShowModule(ModuleType moduleType);
    }
    class PeekModulesHostingService : IPeekModulesHostingService {
        IPeekModulesHost peekModulesHost;
        public PeekModulesHostingService(IPeekModulesHost peekModulesHost) {
            this.peekModulesHost = peekModulesHost;
        }
        bool IPeekModulesHostingService.IsDocked(ModuleType moduleType) {
            return peekModulesHost.IsDocked(moduleType);
        }
        void IPeekModulesHostingService.DockModule(ModuleType moduleType) {
            peekModulesHost.DockModule(moduleType);
        }
        void IPeekModulesHostingService.UndockModule(ModuleType moduleType) {
            peekModulesHost.UndockModule(moduleType);
        }
        void IPeekModulesHostingService.ShowModule(ModuleType moduleType) {
            peekModulesHost.ShowPeek(moduleType);
        }
    }
}