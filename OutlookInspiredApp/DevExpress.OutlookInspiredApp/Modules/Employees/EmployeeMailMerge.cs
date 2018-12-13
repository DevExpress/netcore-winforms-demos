namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraLayout.Utils;

    public partial class EmployeeMailMerge : BaseModuleControl, IRibbonModule {
        public EmployeeMailMerge()
            : base(typeof(EmployeeMailMergeViewModel)) {
            InitializeComponent();
            BindCommands();
            BindEditors();
            UpdateSelectTemplateUI();
            new ZoomLevelManager(beZoomLevel, bbiZoomDialog, new SnapZoomingModel(snapControl));
            //
            ViewModel.MailTemplateChanged += ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged += ViewModel_MailTemplateSelectedChanged;
            ViewModel.Save += ViewModel_Save;
            snapControl.ModifiedChanged += snapControl_ModifiedChanged;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.Save -= ViewModel_Save;
            ViewModel.MailTemplateChanged -= ViewModel_MailTemplateChanged;
            ViewModel.MailTemplateSelectedChanged -= ViewModel_MailTemplateSelectedChanged;
        }
        protected override void OnDisposing() {
            snapControl.ModifiedChanged -= snapControl_ModifiedChanged;
            base.OnDisposing();
        }
        void ViewModel_Save(object sender, EventArgs e) {
            snapControl.SaveDocumentAs();
        }
        void ViewModel_MailTemplateSelectedChanged(object sender, EventArgs e) {
            UpdateSelectTemplateUI();
        }
        void ViewModel_MailTemplateChanged(object sender, EventArgs e) {
            UpdateEditor(ViewModel.MailTemplate.GetValueOrDefault());
        }
        void UpdateEditor(EmployeeMailTemplate mailTemplate) {
            ViewModel.Modified = snapControl.Modified;
            cbMailTemplate.EditValue = mailTemplate;
            LoadTemplate(mailTemplate);
            SynchronizeCurrentRecordWithSnap();
        }
        void LoadTemplate(EmployeeMailTemplate mailTemplate) {
            string template = (mailTemplate.ToFileName() + ".snx");
            using(var stream = MailMergeTemplatesHelper.GetTemplateStream(template))
                snapControl.LoadDocumentTemplate(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate);
        }
        void UpdateSelectTemplateUI() {
            layoutControlMailMergeSetting.Visibility = (ViewModel.IsMailTemplateSelected) ?
                LayoutVisibility.Never : LayoutVisibility.Always;
            mailMergeRibbonPage1.Visible = !ViewModel.IsMailTemplateSelected;
        }
        public EmployeeMailMergeViewModel ViewModel {
            get { return GetViewModel<EmployeeMailMergeViewModel>(); }
        }
        public EmployeeCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        protected override void OnLoad(EventArgs ea) {
            base.OnLoad(ea);
            CollectionViewModel.GetEntities();
            bindingSource.DataSource = CollectionViewModel.SelectedEntity;
            employeesList.DataSource = CollectionViewModel.GetEntities();

            gridView.FocusedRowHandle = gridView.LocateByValue("Id", CollectionViewModel.SelectedEntity.Id);
            if(snapControl.Document.IsEmpty)
                LoadTemplate(ViewModel.MailTemplate.GetValueOrDefault());
            snapControl.DataSource = employeesList.DataSource;
            SynchronizeCurrentRecordWithSnap();
            ViewModel.Modified = snapControl.Modified;
        }
        void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
        }
        void BindEditors() {
            employeesList.Load += (s, e) => GridHelper.SetFindControlImages(employeesList);
            gridView.FocusedRowObjectChanged += gridView_FocusedRowObjectChanged;

            cbMailTemplate.Properties.Items.AddEnum<EmployeeMailTemplate>();
            cbMailTemplate.Properties.SmallImages = CreateImageCollection();
            foreach(DevExpress.XtraEditors.Controls.ImageComboBoxItem item in cbMailTemplate.Properties.Items)
                item.ImageIndex = (int)(EmployeeMailTemplate)item.Value;
            cbMailTemplate.EditValue = ViewModel.MailTemplate.GetValueOrDefault();
            cbMailTemplate.EditValueChanged += cbMailTemplate_EditValueChanged;
        }
        static ImageCollection CreateImageCollection() {
            ImageCollection ret = new ImageCollection();
            ret.ImageSize = new Size(16, 16);
            ret.AddImage(Properties.Resources.icon_employee_quick_thank_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_probation_notice_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_excellence_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_award_16);
            ret.AddImage(Properties.Resources.icon_employee_quick_welcome_16);
            return ret;
        }
        void gridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            Employee employee = e.Row as Employee;
            if(employee != null) {
                bindingSource.DataSource = employee;
                SynchronizeCurrentRecordWithSnap();
            }
        }
        void SynchronizeCurrentRecordWithSnap() {
            snapControl.Options.SnapMailMergeVisualOptions.CurrentRecordIndex = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
        }
        void cbMailTemplate_EditValueChanged(object sender, EventArgs e) {
            ViewModel.MailTemplate = (EmployeeMailTemplate)cbMailTemplate.EditValue;
        }
        void snapControl_ModifiedChanged(object sender, EventArgs e) {
            ViewModel.Modified = snapControl.Modified;
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
        #region IZoomViewModel Members
        class SnapZoomingModel : IZoomViewModel, ISupportZoom {
            object IZoomViewModel.ZoomModule {
                get { return this; }
            }
            event EventHandler IZoomViewModel.ZoomModuleChanged {
                add { }
                remove { }
            }
            DevExpress.Snap.SnapControl snapControl;
            public SnapZoomingModel(DevExpress.Snap.SnapControl snapControl) {
                this.snapControl = snapControl;
                if(snapControl != null)
                    snapControl.ZoomChanged += snapControl_ZoomChanged;
            }
            void snapControl_ZoomChanged(object sender, EventArgs e) {
                RaiseZoomChanged();
            }
            int ISupportZoom.ZoomLevel {
                get { return (int)System.Math.Ceiling(snapControl.ActiveView.ZoomFactor * 100.0f); }
                set { snapControl.ActiveView.ZoomFactor = ((float)value) / 100.0f; }
            }
            public event EventHandler ZoomChanged;
            void RaiseZoomChanged() {
                EventHandler handler = ZoomChanged;
                if(handler != null)
                    handler(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}