namespace DevExpress.DevAV.Modules {
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraEditors;

    public partial class EmployeeEditView : BaseModuleControl, IRibbonModule {
        public EmployeeEditView()
            : base(typeof(EmployeeViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickLetters);
            //
            BindCommands();
            BindEditors();
            gvEvaluations.OptionsView.ShowPreview = false;
            gvTasks.OptionsView.ShowPreview = false;
        }
        public EmployeeViewModel ViewModel {
            get { return GetViewModel<EmployeeViewModel>(); }
        }
        public EmployeeCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        protected override void OnParentViewModelAttached() {
            BindCollectionViewCommands();
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            //Save & Close
            fluent.BindCommand(biSave, x => x.Save());
            fluent.BindCommand(biClose, x => x.Close());
            fluent.BindCommand(biSaveAndClose, x => x.SaveAndClose());
            //Delete
            fluent.BindCommand(biDelete, x => x.Delete());
            //Reload
            fluent.BindCommand(biRefresh, x => x.Reset());
        }
        void BindCollectionViewCommands() {
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            //Map
            fluent.BindCommand(biShowMap, x => x.ShowMap());
            //Print
            fluent.BindCommand(bmiPrintProfile, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Profile);
            fluent.BindCommand(bmiPrintSummary, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Summary);
            fluent.BindCommand(bmiPrintDirectory, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Directory);
            fluent.BindCommand(bmiPrintTaskList, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.TaskList);
            //Mail Merge
            fluent.BindCommand(biMailMerge, x => x.MailMerge());
            //Quick Letters
            fluent.BindCommand(GalleryQuickLetterItem(0), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ThankYouNote);
            fluent.BindCommand(GalleryQuickLetterItem(1), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.EmployeeOfTheMonth);
            fluent.BindCommand(GalleryQuickLetterItem(2), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ServiceExcellence);
            fluent.BindCommand(GalleryQuickLetterItem(3), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ProbationNotice);
            fluent.BindCommand(GalleryQuickLetterItem(4), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.WelcomeToDevAV);
            //
            fluent.BindCommand(biMeeting, x => x.ShowMeeting());
            fluent.BindCommand(biTask, x => x.ShowTask());
        }
        XtraBars.Ribbon.GalleryItem GalleryQuickLetterItem(int index) {
            return galleryQuickLetters.Gallery.Groups[0].Items[index];
        }
        void BindEditors() {
            StatusImageComboBoxEdit.Properties.Items.AddEnum<EmployeeStatus>();
            EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, null);
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(null, gridControlTasks.RepositoryItems);
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum<EmployeeDepartment>();
            StateImageComboBoxEdit.Properties.Items.AddEnum<StateEnum>();
            //
            ZipCodeTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.ZipCode", true, DataSourceUpdateMode.OnPropertyChanged));
            StateImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.State", true, DataSourceUpdateMode.OnPropertyChanged));
            CityTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.City", true, DataSourceUpdateMode.OnPropertyChanged));
            AddressTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.Line", true, DataSourceUpdateMode.OnPropertyChanged));
            //
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            fluent.BindCommand(ContactButton(MobilePhoneTextEdit), x => x.Contacts.MobileCall());
            fluent.BindCommand(ContactButton(HomePhoneTextEdit), x => x.Contacts.HomeCall());
            fluent.BindCommand(ContactButton(EmailTextEdit), x => x.Contacts.MailTo());
            fluent.BindCommand(ContactButton(SkypeTextEdit), x => x.Contacts.VideoCall());
            //
            fluent.SetBinding(ribbonControl, r => r.ApplicationDocumentCaption, x => x.Title);
            fluent.SetObjectDataSourceBinding(bindingSource, x => x.Entity, x => x.Update());
            //
            foreach(Control control in moduleDataLayout.Controls) {
                BaseEdit edit = control as BaseEdit;
                if(edit == null || edit.DataBindings.Count == 0) continue;
                EditorHelpers.ApplyBindingSettings<Employee>(edit, moduleDataLayout);
            }
            //
            FirstNameTextEdit.EditValueChanged += (s, e) => QueueFullNameUpdate();
            LastNameTextEdit.EditValueChanged += (s, e) => QueueFullNameUpdate();
            FullNameTextEdit.EditValueChanged += (s, e) => QueueFullNameUpdate();
        }
        XtraEditors.Controls.EditorButton ContactButton(XtraEditors.ButtonEdit edit, int index = 0) {
            return edit.Properties.Buttons[index];
        }
        int fullNameUpdateQueued = 0;
        void QueueFullNameUpdate() {
            if(0 == fullNameUpdateQueued) {
                fullNameUpdateQueued++;
                BeginInvoke(new MethodInvoker(UpdateFullNameEditValue));
            }
            else fullNameUpdateQueued++;
        }
        void UpdateFullNameEditValue() {
            FullNameTextEdit.DataBindings["EditValue"].ReadValue();
            fullNameUpdateQueued = 0;
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
        void gvEvaluations_RowCellStyle(object sender, XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            Evaluation evaluation = gvEvaluations.GetRow(e.RowHandle) as Evaluation;
            if(evaluation == null) return;
            if(evaluation.Rating == EvaluationRating.Good) e.Appearance.ForeColor = ColorHelper.InformationColor;
            if(evaluation.Rating == EvaluationRating.Poor) e.Appearance.ForeColor = ColorHelper.CriticalColor;
        }
    }
}