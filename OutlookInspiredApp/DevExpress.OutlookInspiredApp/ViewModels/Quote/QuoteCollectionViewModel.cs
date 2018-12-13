using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the Quotes collection view model.
    /// </summary>
    public partial class QuoteCollectionViewModel : CollectionViewModel<Quote, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of QuoteCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static QuoteCollectionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new QuoteCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the QuoteCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QuoteCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected QuoteCollectionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Quotes, query => query.ActualQuotes()) {
        }
    }
}