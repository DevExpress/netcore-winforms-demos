namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class EmployeeCollectionViewModel : ISupportMap, ISupportCustomFilters {
        public override void Refresh() {
            base.Refresh();
            RaiseReload();
        }
        protected override void OnEntityChanged(Employee entity) {
            entity.ResetBindable();
        }
        protected override void OnSelectedEntityChanged() {
            base.OnSelectedEntityChanged();
            this.RaiseCanExecuteChanged(x => x.ShowMap());
            this.RaiseCanExecuteChanged(x => x.PrintProfile());
            this.RaiseCanExecuteChanged(x => x.MailMerge());
            this.RaiseCanExecuteChanged(x => x.QuickLetter(EmployeeMailTemplate.ThankYouNote));
        }
        public virtual IEnumerable<Employee> Selection { get; set; }
        protected virtual void OnSelectionChanged() {
            this.RaiseCanExecuteChanged(x => x.GroupSelection());
        }
        public event EventHandler Reload;
        public event EventHandler CustomFilter;
        public event EventHandler CustomFiltersReset;
        public event EventHandler CustomGroup;
        public event EventHandler<GroupEventArgs<Employee>> CustomGroupFromSelection;
        [Command]
        public void ShowMap() {
            ShowMapCore(SelectedEntity);
        }
        public bool CanShowMap() {
            return CanShowMapCore(SelectedEntity);
        }
        protected internal void ShowMapCore(Employee employee) {
            ShowDocument<EmployeeMapViewModel>("MapView", employee.Id);
        }
        protected internal bool CanShowMapCore(Employee employee) {
            return employee != null;
        }
        [Command]
        public void ShowViewSettings() {
            var dms = this.GetService<DevExpress.Mvvm.IDocumentManagerService>("View Settings");
            if(dms != null) {
                var document = dms.Documents.FirstOrDefault(d => d.Content is ViewSettingsViewModel);
                if(document == null)
                    document = dms.CreateDocument("View Settings", null, null, this);
                document.Show();
            }
        }
        [Command]
        public void NewGroup() {
            RaiseCustomGroup();
        }
        [Command]
        public void GroupSelection() {
            RaiseCustomGroupFromSelection();
        }
        public bool CanGroupSelection() {
            return (Selection != null) && Selection.Any();
        }
        [Command]
        public void NewCustomFilter() {
            RaiseCustomFilter();
        }
        [Command]
        public void PrintProfile() {
            PrintCore(SelectedEntity, EmployeeReportType.Profile);
        }
        public bool CanPrintProfile() {
            return CanPrintProfileCore(SelectedEntity);
        }
        protected internal void PrintCore(Employee employee, EmployeeReportType reportType) {
            RaisePrint(reportType);
        }
        protected internal bool CanPrintProfileCore(Employee employee) {
            return employee != null;
        }
        static readonly string scheduler = "This demo does not include integration with our WinForms Scheduler Suite but you can easily introduce" + Environment.NewLine +
            "Outlook-inspired scheduling and task management capabilities to your apps with DevExpress Tools.";
        [Command]
        public void ShowMeeting() {
            SchedulerMessage("Meeting");
        }
        [Command]
        public void ShowTask() {
            SchedulerMessage("Tasks");
        }
        void SchedulerMessage(string caption) {
            MessageBoxService.Show(scheduler, caption, DevExpress.Mvvm.MessageButton.OK, DevExpress.Mvvm.MessageIcon.Information, DevExpress.Mvvm.MessageResult.OK);
        }
        [Command]
        public void PrintSummary() {
            RaisePrint(EmployeeReportType.Summary);
        }
        [Command]
        public void PrintDirectory() {
            RaisePrint(EmployeeReportType.Directory);
        }
        [Command]
        public void PrintTaskList() {
            RaisePrint(EmployeeReportType.TaskList);
        }
        [Command(UseCommandManager = false, CanExecuteMethodName = "CanPrintProfile")]
        public void MailMerge() {
            ShowDocument<EmployeeMailMergeViewModel>("MailMerge", null);
        }
        [Command]
        public void QuickLetter(EmployeeMailTemplate mailTemplate) {
            QuickLetterCore(SelectedEntity, mailTemplate);
        }
        public bool CanQuickLetter(EmployeeMailTemplate mailTemplate) {
            return CanQuickLetterCore(SelectedEntity, mailTemplate);
        }
        protected internal void QuickLetterCore(Employee employee, EmployeeMailTemplate mailTemplate) {
            ShowDocument<EmployeeMailMergeViewModel>("MailMerge", mailTemplate);
        }
        protected internal bool CanQuickLetterCore(Employee employee, EmployeeMailTemplate mailTemplate) {
            return employee != null;
        }
        [Command]
        public void ShowAllFolders() {
            RaiseShowAllFolders();
        }
        [Command]
        public void ResetCustomFilters() {
            RaiseCustomFiltersReset();
        }
        void RaisePrint(EmployeeReportType reportType) {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaisePrint(reportType);
        }
        void RaiseShowAllFolders() {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaiseShowAllFolders();
        }
        void RaiseReload() {
            EventHandler handler = Reload;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFilter() {
            EventHandler handler = CustomFilter;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFiltersReset() {
            EventHandler handler = CustomFiltersReset;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomGroup() {
            EventHandler handler = CustomGroup;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomGroupFromSelection() {
            EventHandler<GroupEventArgs<Employee>> handler = CustomGroupFromSelection;
            if(handler != null)
                handler(this, new GroupEventArgs<Employee>(Selection));
        }
        void ShowDocument<TViewModel>(string documentType, object parameter) {
            var document = FindDocument<TViewModel>();
            if(parameter is long)
                document = FindDocument<TViewModel>((long)parameter);
            if(document == null)
                document = DocumentManagerService.CreateDocument(documentType, null, parameter, this);
            else
                ViewModelHelper.EnsureViewModel(document.Content, this, parameter);
            document.Show();
        }
    }
}