namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class EmployeeViewModel {
        public new bool IsNew() { return base.IsNew(); }
        EmployeeContactsViewModel contacts;
        public EmployeeContactsViewModel Contacts {
            get {
                if(contacts == null)
                    contacts = EmployeeContactsViewModel.Create().SetParentViewModel(this);
                return contacts;
            }
        }
        protected override string GetTitle() {
            return Entity.FullName;
        }
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            Contacts.Entity = Entity;
            this.RaiseCanExecuteChanged(x => x.ShowMap());
            this.RaiseCanExecuteChanged(x => x.MailMerge());
            this.RaiseCanExecuteChanged(x => x.Print(EmployeeReportType.Profile));
            this.RaiseCanExecuteChanged(x => x.QuickLetter(EmployeeMailTemplate.ThankYouNote));
            EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler EntityChanged;
        [Command]
        public void QuickLetter(EmployeeMailTemplate mailTemplate) {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.QuickLetterCore(Entity, mailTemplate);
        }
        public bool CanQuickLetter(EmployeeMailTemplate mailTemplate) {
            if(Entity == null || IsNew()) return false;
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            return (collectionViewModel != null) && collectionViewModel.CanQuickLetterCore(Entity, mailTemplate);
        }
        [Command]
        public void Print(EmployeeReportType reportType) {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.PrintCore(Entity, reportType);
        }
        public bool CanPrint(EmployeeReportType reportType) {
            if(Entity == null || IsNew()) return false;
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            return (collectionViewModel != null) && collectionViewModel.CanPrintProfileCore(Entity);
        }
        [Command]
        public void MailMerge() {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.MailMerge();
        }
        public bool CanMailMerge() {
            return (Entity != null) && !IsNew();
        }
        [Command]
        public void ShowMap() {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.ShowMapCore(Entity);
        }
        public bool CanShowMap() {
            if(Entity == null || IsNew()) return false;
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            return (collectionViewModel != null) && collectionViewModel.CanShowMapCore(Entity);
        }
        [Command]
        public void ShowMeeting() {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.ShowMeeting();
        }
        public bool CanShowMeeting() {
            return (Entity != null) && !IsNew();
        }
        [Command]
        public void ShowTask() {
            EmployeeCollectionViewModel collectionViewModel = ViewModelHelper.GetParentViewModel<EmployeeCollectionViewModel>(this);
            if(collectionViewModel != null)
                collectionViewModel.ShowTask();
        }
        public bool CanShowTask() {
            return (Entity != null) && !IsNew();
        }
    }
    public partial class SynchronizedEmployeeViewModel : EmployeeViewModel {
        protected override bool EnableSelectedItemSynchronization { 
            get { return true; } 
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}