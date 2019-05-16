using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.DevAV.Common;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;

namespace DevExpress.DevAV.ViewModels {

    /// <summary>
    /// Represents the Employees collection view model.
    /// </summary>
    public partial class EmployeeCollectionViewModel : CollectionViewModel<Employee, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeCollectionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null, UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual) {
            return ViewModelSource.Create(() => new EmployeeCollectionViewModel(unitOfWorkFactory, unitOfWorkPolicy));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeCollectionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null, UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, unitOfWorkPolicy: unitOfWorkPolicy) {
        }
    }
}