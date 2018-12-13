namespace DevExpress.DevAV.Services {
    using System;
    using DevExpress.DevAV;
    using DevExpress.XtraSplashScreen;

    public interface IWaitingService {
        void BeginWaiting(object parameter);
        void EndWaiting();
    }
    class WaitingService : IWaitingService {
        void IWaitingService.BeginWaiting(object parameter) {
            ShowWaitForm(DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(parameter));
        }
        void IWaitingService.EndWaiting() {
            CloseWaitForm();
        }
        static void ShowWaitForm(string caption) {
            if(SplashScreenManager.Default == null) 
                SplashScreenManager.ShowDefaultWaitForm(AppHelper.MainForm, false, false, false, 250, caption);
        }
        static void CloseWaitForm() {
            var ssm = SplashScreenManager.Default;
            if(ssm != null && ssm.ActiveSplashFormTypeInfo != null && ssm.ActiveSplashFormTypeInfo.Mode == Mode.WaitForm)
                SplashScreenManager.CloseForm(false, 750, AppHelper.MainForm);
        }
    }
    //
    class LoadingService : IWaitingService {
        System.Windows.Forms.UserControl owner;
        public LoadingService(System.Windows.Forms.UserControl owner) {
            this.owner = owner;
        }
        void IWaitingService.BeginWaiting(object parameter) {
            ShowWaitForm(owner, parameter.ToString());
        }
        void IWaitingService.EndWaiting() {
            CloseWaitForm();
        }
        static void ShowWaitForm(System.Windows.Forms.UserControl owner, string caption) {
            if(SplashScreenManager.Default == null)
                SplashScreenManager.ShowDefaultWaitForm((owner != null) ? owner.FindForm() : null, false, false, caption);
        }
        static void CloseWaitForm() {
            var ssm = SplashScreenManager.Default;
            if(ssm != null && ssm.ActiveSplashFormTypeInfo != null && ssm.ActiveSplashFormTypeInfo.Mode == Mode.WaitForm)
                SplashScreenManager.CloseForm(false, 250, AppHelper.MainForm);
        }
    }
    //
    public static class WaitingServiceExtension {
        static WaitingServiceExtension() {
            SplashScreenManager.ActivateParentOnWaitFormClosing = false;
        }
        public static IDisposable Enter(this IWaitingService service, object parameter, bool effective = true) {
            return new WaitingBatch(effective ? service : null, parameter);
        }
        class WaitingBatch : IDisposable {
            IWaitingService service;
            public WaitingBatch(IWaitingService service, object parameter) {
                this.service = service;
                if(service != null)
                    service.BeginWaiting(parameter);
            }
            public void Dispose() {
                if(service != null)
                    service.EndWaiting();
            }
        }
    }
}