using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Order object view model.
    /// </summary>
    public partial class OrderViewModel : SingleObjectViewModel<Order, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders, x => x.InvoiceNumber) {
        }

        /// <summary>
		/// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpCustomers, x => x.Customers); }
        }

        /// <summary>
		/// The view model that contains a look-up collection of CustomerStores for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerStore> LookUpCustomerStores {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpCustomerStores, x => x.CustomerStores); }
        }

        /// <summary>
		/// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }

        ///// <summary>
        ///// The view model for the OrderOrderItems detail collection.
        ///// </summary>
        //public CollectionViewModel<OrderItem, long, IDevAVDbUnitOfWork> OrderOrderItemsDetails { 
        //    get { return GetDetailsCollectionViewModel((OrderViewModel x) => x.OrderOrderItemsDetails, x => x.OrderItems, x => x.OrderId, (x, key) => x.OrderId = key); } 
        //}
    }
}