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
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.Name) {
        }

        /// <summary>
        /// The view model for the CustomerEmployees detail collection.
        /// </summary>
        public CollectionViewModelBase<CustomerEmployee, CustomerEmployee, long, IDevAVDbUnitOfWork> CustomerEmployeesDetails {
            get { return GetDetailsCollectionViewModel((CustomerViewModel x) => x.CustomerEmployeesDetails, x => x.CustomerEmployees, x => x.CustomerId, (x, key) => x.CustomerId = key); }
        }

        /// <summary>
        /// The view model for the CustomerOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, long, IDevAVDbUnitOfWork> CustomerOrdersDetails {
            get { return GetDetailsCollectionViewModel((CustomerViewModel x) => x.CustomerOrdersDetails, x => x.Orders, x => x.CustomerId, (x, key) => x.CustomerId = key, query => query.ActualOrders()); }
        }

        /// <summary>
        /// The view model for the CustomerQuotes detail collection.
        /// </summary>
        public CollectionViewModelBase<Quote, Quote, long, IDevAVDbUnitOfWork> CustomerQuotesDetails {
            get { return GetDetailsCollectionViewModel((CustomerViewModel x) => x.CustomerQuotesDetails, x => x.Quotes, x => x.CustomerId, (x, key) => x.CustomerId = key, query => query.ActualQuotes()); }
        }

        /// <summary>
        /// The view model for the CustomerCustomerStores detail collection.
        /// </summary>
        public CollectionViewModelBase<CustomerStore, CustomerStore, long, IDevAVDbUnitOfWork> CustomerCustomerStoresDetails {
            get { return GetDetailsCollectionViewModel((CustomerViewModel x) => x.CustomerCustomerStoresDetails, x => x.CustomerStores, x => x.CustomerId, (x, key) => x.CustomerId = key); }
        }
    }
}
