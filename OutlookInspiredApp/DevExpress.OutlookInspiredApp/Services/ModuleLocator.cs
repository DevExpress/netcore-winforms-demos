namespace DevExpress.DevAV.Services {
    using System;
    using System.Collections.Generic;
    using IServiceContainer = DevExpress.Mvvm.IServiceContainer;

    public interface IModuleLocator {
        bool IsModuleLoaded(ModuleType moduleType);
        object GetModule(ModuleType moduleType);
        object CreateModule(ModuleType moduleType);
        object GetModule(ModuleType moduleType, object viewModel);
        object GetModule(ModuleType moduleType, long keyParameter);
        void ReleaseModule(object module);
    }
    public interface IReportLocator {
        object GetReport(object reportKey);
        void ReleaseReport(object reportKey);
    }
    //
    class ModuleLocator : IModuleLocator {
        IServiceContainer serviceContainer;
        IDictionary<ModuleType, WeakReference> modulesCache;
        IDictionary<ModuleType, IDictionary<long, WeakReference>> modulesIdentityCache;
        public ModuleLocator(IServiceContainer serviceContainer) {
            this.serviceContainer = serviceContainer;
            this.modulesCache = new Dictionary<ModuleType, WeakReference>();
            this.modulesIdentityCache = new Dictionary<ModuleType, IDictionary<long, WeakReference>>();
        }
        public bool IsModuleLoaded(ModuleType moduleType) {
            return modulesCache.ContainsKey(moduleType);
        }
        public object CreateModule(ModuleType moduleType) {
            var activator = serviceContainer.GetService<IModuleActivator>();
            var resolver = serviceContainer.GetService<IModuleTypesResolver>();
            return activator.CreateModule(resolver.GetTypeName(moduleType));
        }
        public object GetModule(ModuleType moduleType, long keyParameter) {
            if(moduleType == ModuleType.Unknown) return null;
            var activator = serviceContainer.GetService<IModuleActivator>();
            IDictionary<long, WeakReference> identityCache;
            if(!modulesIdentityCache.TryGetValue(moduleType, out identityCache)) {
                identityCache = new Dictionary<long, WeakReference>();
                modulesIdentityCache.Add(moduleType, identityCache);
            }
            return GetModuleCore(identityCache, keyParameter, moduleType, (moduleTypeName, parameter) => activator.CreateModule(moduleTypeName), null);
        }
        public object GetModule(ModuleType moduleType, object viewModel) {
            if(moduleType == ModuleType.Unknown) return null;
            var activator = serviceContainer.GetService<IModuleActivator>();
            return GetModuleCore(modulesCache, moduleType, (moduleTypeName, parameter) => activator.CreateModule(moduleTypeName, parameter), viewModel);
        }
        public object GetModule(ModuleType moduleType) {
            if(moduleType == ModuleType.Unknown) return null;
            var activator = serviceContainer.GetService<IModuleActivator>();
            return GetModuleCore(modulesCache, moduleType, (moduleTypeName, parameter) => activator.CreateModule(moduleTypeName), null);
        }
        public void ReleaseModule(object module) {
            ClearCore(modulesCache, module);
            foreach(var item in modulesIdentityCache)
                ClearCore(item.Value, module);
        }
        object GetModuleCore(IDictionary<ModuleType, WeakReference> cache, ModuleType moduleType, Func<string, object, object> activatorRoutine, object parameter) {
            return GetModuleCore(cache, moduleType, moduleType, activatorRoutine, parameter);
        }
        object GetModuleCore<TKey>(IDictionary<TKey, WeakReference> cache, TKey key, ModuleType moduleType, Func<string, object, object> activatorRoutine, object parameter) {
            WeakReference moduleReference;
            if(!cache.TryGetValue(key, out moduleReference) || moduleReference.Target == null) {
                var resolver = serviceContainer.GetService<IModuleTypesResolver>();
                var module = activatorRoutine(resolver.GetTypeName(moduleType), parameter);
                if(moduleReference == null) {
                    moduleReference = new WeakReference(module);
                    cache.Add(key, moduleReference);
                    var ribbonModule = module as Modules.IRibbonModule;
                    if(ribbonModule != null && resolver.GetMainModuleType(moduleType) == moduleType) {
                        ribbonModule.Ribbon.Manager.HideBarsWhenMerging = false;
                        ribbonModule.Ribbon.StatusBar.HideWhenMerging = Utils.DefaultBoolean.False;
                        ribbonModule.Ribbon.StatusBar.Visible = ribbonModule.Ribbon.Visible = false;
                    }
                }
                else moduleReference.Target = module;
            }
            return moduleReference.Target;
        }
        void ClearCore<TKey>(IDictionary<TKey, WeakReference> cache, object module) {
            TKey key = default(TKey);
            foreach(var item in cache) {
                if(!object.Equals(item.Value.Target, module)) continue;
                key = item.Key;
                break;
            }
            cache.Remove(key);
        }
    }
    class ReportLocator : IReportLocator {
        IServiceContainer serviceContainer;
        IDictionary<object, WeakReference> reportsCache;
        public ReportLocator(IServiceContainer serviceContainer) {
            this.serviceContainer = serviceContainer;
            this.reportsCache = new Dictionary<object, WeakReference>();
        }
        public object GetReport(object reportKey) {
            if(object.ReferenceEquals(reportKey, null)) return null;
            WeakReference reportReference;
            if(!reportsCache.TryGetValue(reportKey, out reportReference) || reportReference.Target == null) {
                var activator = serviceContainer.GetService<IReportActivator>();
                var report = activator.CreateReport(reportKey);
                if(reportReference == null) {
                    reportReference = new WeakReference(report);
                    reportsCache.Add(reportKey, reportReference);
                }
                else reportReference.Target = report;
            }
            return reportReference.Target;
        }
        public void ReleaseReport(object reportKey) {
            if(object.ReferenceEquals(reportKey, null)) return;
            WeakReference report;
            if(reportsCache.TryGetValue(reportKey, out report)) {
                reportsCache.Remove(reportKey);
                IDisposable disposable = report.Target as IDisposable;
                if(disposable != null)
                    disposable.Dispose();
            }
        }
    }
}