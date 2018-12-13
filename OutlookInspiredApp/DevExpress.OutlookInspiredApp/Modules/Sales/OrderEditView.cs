using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.DevAV.ViewModels;
using DevExpress.Spreadsheet;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.DevAV.Modules {
    public partial class OrderEditView : BaseModuleControl, IRibbonModule {
        public OrderEditView()
            : base(typeof(OrderViewModel)) {
            InitializeComponent();
            var fluent = mvvmContext.OfType<OrderViewModel>();
            fluent.SetBinding(ribbonControl, r => r.ApplicationDocumentCaption, x => x.Title);
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<OrderViewModel>();
            //Save & Close
            fluent.BindCommand(biSave, x => x.Save());
            fluent.BindCommand(biClose, x => x.Close());
            fluent.BindCommand(biSaveAndClose, x => x.SaveAndClose());
            //Delete
            fluent.BindCommand(biDelete, x => x.Delete());
            //Reload
            fluent.BindCommand(biReset, x => x.Reset());
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            BindCommands();
            //LoadInvoiceTemplate();
            //CreateInvoiceHelper();
        }
        public OrderViewModel ViewModel {
            get { return GetViewModel<OrderViewModel>(); }
        }
        //void LoadInvoiceTemplate() {
        //    using(var stream = InvoiceHelper.GetInvoiceTemplate())
        //        spreadsheetControl1.LoadDocument(stream);
        //}
        //InvoiceHelper invoiceHelper;
        //void CreateInvoiceHelper() {
        //    var actions = CreateInvoiceEditActions();
        //    var dataSource = ViewModel.CreateInvoiceDataSource();
        //    this.invoiceHelper = new InvoiceHelper(spreadsheetControl1.Document, dataSource, actions);
        //}
        //EditActions CreateInvoiceEditActions() {
        //    EditActions actions = new EditActions();
        //    actions.IsDefaultActions = false;
        //    // Do not simplify lines below due to VB convertation
        //    actions.GetCustomerStores = new Func<long?, IEnumerable<CustomerStore>>(ViewModel.GetCustomerStores);
        //    actions.CreateOrderItem = new Func<OrderItem>(ViewModel.CreateOrderItem);
        //    actions.AddOrderItem = new Action<OrderItem>(ViewModel.AddOrderItem);
        //    actions.RemoveOrderItem = new Action<OrderItem>(ViewModel.RemoveOrderItem);
        //    actions.ActivateEditor = new Action(SpreadsheetControl_ActivateEditor);
        //    actions.CloseEditor = new Action(SpreadsheetControl_CloseEditor);
        //    // Do not simplify lines above due to VB convertation
        //    return actions;
        //}
        //void SpreadsheetControl_ActivateEditor() {
        //    Worksheet activeSheet = spreadsheetControl1.ActiveWorksheet;
        //    if(activeSheet.Name == CellsHelper.InvoiceWorksheetName) {
        //        if(activeSheet.CustomCellInplaceEditors.GetCustomCellInplaceEditors(activeSheet.Selection).Count > 0)
        //            spreadsheetControl1.OpenCellEditor(XtraSpreadsheet.CellEditorMode.Edit);
        //    }
        //}
        void SpreadsheetControl_CloseEditor() {
            if(spreadsheetControl1.IsCellEditorActive)
                spreadsheetControl1.CloseCellEditor(XtraSpreadsheet.CellEditorEnterValueMode.Cancel);
        }
        void SpreadsheetControl_CustomCellEdit(object sender, XtraSpreadsheet.SpreadsheetCustomCellEditEventArgs e) {
            if(!e.ValueObject.IsText)
                return;
            //var editorInfo = CellsHelper.FindEditor(e.ValueObject.TextValue);
            //if(editorInfo != null && e.RepositoryItem is RepositoryItemSpinEdit) {
            //    RepositoryItemSpinEdit repositoryItemSpinEdit = e.RepositoryItem as RepositoryItemSpinEdit;
            //    repositoryItemSpinEdit.MinValue = editorInfo.MinValue;
            //    repositoryItemSpinEdit.MaxValue = editorInfo.MaxValue;
            //    repositoryItemSpinEdit.Increment = editorInfo.Increment;
            //    repositoryItemSpinEdit.IsFloatValue = false;
            //}
        }
        void SpreadsheetControl_SelectionChanged(object sender, EventArgs e) {
            //invoiceHelper.SelectionChanged();
        }
        void SpreadsheetControl_CellValueChanged(object sender, XtraSpreadsheet.SpreadsheetCellEventArgs e) {
            //invoiceHelper.CellValueChanged(sender, e);
            ViewModel.Update();
        }
        void SpreadsheetControl_MouseClick(object sender, MouseEventArgs e) {
            //if(e.Button == MouseButtons.Left)
            //    invoiceHelper.OnPreviewMouseLeftButton(spreadsheetControl1.GetCellFromPoint(e.Location));
        }
        void SpreadsheetControl_ProtectionWarning(object sender, HandledEventArgs e) {
            e.Handled = true;
        }
        void SpreadsheetControl_CustomDrawCell(object sender, XtraSpreadsheet.CustomDrawCellEventArgs e) {
            Worksheet sheet = e.Cell.Worksheet;
            if(sheet.Name != "Invoice")
                return;
            DefinedName invoiceItems = sheet.DefinedNames.GetDefinedName("InvoiceItems");
            // Add Order Item
            if(e.Cell.ColumnIndex == 2 &&
                e.Cell.RowIndex == (invoiceItems == null ? 21 : invoiceItems.Range.BottomRowIndex + 1))
                DrawLink(e, e.Cache, "Add Order Item");
            // Delete Order Item
            if(invoiceItems != null && e.Cell.ColumnIndex == 13 && invoiceItems.Range.RowCount > 1 &&
                e.Cell.RowIndex >= invoiceItems.Range.TopRowIndex && e.Cell.RowIndex <= invoiceItems.Range.BottomRowIndex)
                DrawLink(e, e.Cache, "Delete Order Item");
        }
        void DrawLink(CustomDrawCellEventArgs e, GraphicsCache cache, string text) {
            e.DrawDefault();
            e.Handled = true;
            var brush = cache.GetSolidBrush(Color.FromArgb(5, 111, 206));
            var font = cache.GetFont(e.Font, FontStyle.Underline);
            SizeF size = cache.CalcTextSize(text, font, StringFormat.GenericDefault, 0);
            float height = (float)e.Bounds.Height - size.Height;
            RectangleF textBounds = new RectangleF(e.Bounds.Left + 8, e.Bounds.Top + height / 2, size.Width + 4, size.Height);
            cache.DrawString(text, font, brush, Rectangle.Round(textBounds), StringFormat.GenericDefault);
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}