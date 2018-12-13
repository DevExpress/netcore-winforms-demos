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

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Quote object view model.
    /// </summary>
    public partial class QuoteViewModel : SingleObjectViewModel<Quote, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of QuoteViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static QuoteViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new QuoteViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the QuoteViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QuoteViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected QuoteViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Quotes, x => x.Number) {
        }

        /// <summary>
		/// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get { return GetLookUpEntitiesViewModel((QuoteViewModel x) => x.LookUpCustomers, x => x.Customers); }
        }

        /// <summary>
		/// The view model that contains a look-up collection of CustomerStores for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerStore> LookUpCustomerStores {
            get { return GetLookUpEntitiesViewModel((QuoteViewModel x) => x.LookUpCustomerStores, x => x.CustomerStores); }
        }

        /// <summary>
		/// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((QuoteViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }

        /// <summary>
        /// The view model for the QuoteQuoteItems detail collection.
        /// </summary>
        public CollectionViewModel<QuoteItem, long, IDevAVDbUnitOfWork> QuoteQuoteItemsDetails { 
            get { return GetDetailsCollectionViewModel((QuoteViewModel x) => x.QuoteQuoteItemsDetails, x => x.QuoteItems, x => x.QuoteId, (x, key) => x.QuoteId = key); } 
        }
    }
}
