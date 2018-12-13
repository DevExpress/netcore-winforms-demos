namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using System.Linq;

    partial class OrderViewModel {
        public event EventHandler CustomizeFilter;
        public event EventHandler EntityChanged;
        void RaiseCustomizeFilter() {
            EventHandler handler = CustomizeFilter;
            if(handler != null) handler(this, EventArgs.Empty);
        }
        protected override string GetTitle() {
            return string.Format("Invoice# {0}", Entity.InvoiceNumber);
        }
        void RaiseEntityChanged() {
            EventHandler handler = EntityChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
        //
        public OrderCollectionViewModel OrderCollectionViewModel {
            get { return this.GetParentViewModel<OrderCollectionViewModel>(); }
        }
        public Order MasterEntity {
            get { return (OrderCollectionViewModel != null) ? OrderCollectionViewModel.SelectedEntity : null; }
        }
        // Edit
        protected bool CanEdit() {
            return MasterEntity != null;
        }
        public void Edit() {
            OrderCollectionViewModel.Edit(MasterEntity);
            RaiseCustomizeFilter();
        }
        // Delete
        public override bool CanDelete() {
            return MasterEntity != null;
        }
        public override void Delete() {
            OrderCollectionViewModel.Delete(MasterEntity);
        }
        // Refund
        protected bool CanIssueFullRefund() {
            return (MasterEntity != null) && (MasterEntity.RefundTotal < MasterEntity.PaymentTotal);
        }
        public void IssueFullRefund() {
            MasterEntity.RefundTotal = MasterEntity.PaymentTotal;
            OrderCollectionViewModel.Save(MasterEntity);
        }
        public virtual string IssueFullRefundToolTip { get; set; }
        // Mark Paid
        protected bool CanMarkPaid() {
            return (MasterEntity != null) && (MasterEntity.PaymentTotal < MasterEntity.TotalAmount);
        }
        public void MarkPaid() {
            MasterEntity.PaymentTotal = MasterEntity.TotalAmount;
            OrderCollectionViewModel.Save(MasterEntity);
        }
        public virtual string MarkPaidToolTip { get; set; }
        // Mail To
        protected bool CanMailTo() {
            return Entity != null;
        }
        public void MailTo() {
            EmployeeContactsViewModel.ExecuteMailTo(MessageBoxService, Entity.Employee.Email);
        }
        // Print
        protected bool CanPrint() {
            return OrderCollectionViewModel != null;
        }
        public void Print() {
            OrderCollectionViewModel.PrintInvoice();
        }
        // Dependencies
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            RaiseEntityChanged();
        }
        protected override void UpdateCommands() {
            base.UpdateCommands();
            this.RaiseCanExecuteChanged(x => x.Edit());
            this.RaiseCanExecuteChanged(x => x.MailTo());
            this.RaiseCanExecuteChanged(x => x.Print());
            this.RaiseCanExecuteChanged(x => x.MarkPaid());
            this.RaiseCanExecuteChanged(x => x.IssueFullRefund());
            MarkPaidToolTip = CanMarkPaid() ? "Mark as Paid" : "Paid";
            IssueFullRefundToolTip = CanIssueFullRefund() ? "Issue Full Refund" : "Refund Issued";
        }
        // Custom Actions
        [Command(false)]
        public OrderItem CreateOrderItem() {
            return UnitOfWork.OrderItems.Create();
        }
        [Command(false)]
        public void AddOrderItem(OrderItem orderItem) {
            UnitOfWork.OrderItems.Add(orderItem);
        }
        [Command(false)]
        public void RemoveOrderItem(OrderItem orderItem) {
            UnitOfWork.OrderItems.Remove(orderItem);
        }
        [Command(false)]
        public IEnumerable<CustomerStore> GetCustomerStores(long? customerId) {
            return UnitOfWork.CustomerStores.Where(x => Nullable.Equals(x.CustomerId, customerId));
        }
        //[Command(false)]
        //public Tuple<OrderCollections, Order> CreateInvoiceDataSource() {
        //    var collections = new OrderCollections();
        //    collections.Customers = UnitOfWork.Customers;
        //    collections.Products = UnitOfWork.Products;
        //    collections.Employees = UnitOfWork.Employees;
        //    collections.CustomerStores = GetCustomerStores(Entity.CustomerId);
        //    return new Tuple<OrderCollections, Order>(collections, Entity);
        //}
        public override bool CanSave() {
            return base.CanSave() && Entity.OrderItems.Any();
        }
    }

    public partial class SynchronizedOrderViewModel : OrderViewModel {
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
    }
}