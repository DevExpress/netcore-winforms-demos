namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    public class QuoteMapViewModel : QuoteViewModel {
        public virtual Stage Stage { get; set; }
        [Command]
        public void SetHighStage() {
            Stage = Stage.High;
        }
        public bool CanSetHighStage() {
            return Stage != Stage.High;
        }
        [Command]
        public void SetMediumStage() {
            Stage = Stage.Medium;
        }
        public bool CanSetMediumStage() {
            return Stage != Stage.Medium;
        }
        [Command]
        public void SetLowStage() {
            Stage = Stage.Low;
        }
        public bool CanSetLowStage() {
            return Stage != Stage.Low;
        }
        [Command]
        public void SetUnlikelyStage() {
            Stage = Stage.Unlikely;
        }
        public bool CanSetUnlikelyStage() {
            return Stage != Stage.Unlikely;
        }
        protected virtual void OnStageChanged() {
            this.RaiseCanExecuteChanged(x => x.SetHighStage());
            this.RaiseCanExecuteChanged(x => x.SetMediumStage());
            this.RaiseCanExecuteChanged(x => x.SetLowStage());
            this.RaiseCanExecuteChanged(x => x.SetUnlikelyStage());
            RaiseStageChanged();
        }
        public event EventHandler StageChanged;
        void RaiseStageChanged() {
            EventHandler handler = StageChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}