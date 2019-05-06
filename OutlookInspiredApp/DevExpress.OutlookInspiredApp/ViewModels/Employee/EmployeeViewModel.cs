using System;
using System.Linq;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.FullName) {
        }

        /// <summary>
		/// The view model that contains a look-up collection of Pictures for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Picture> LookUpPictures {
            get {
                return GetLookUpEntitiesViewModel<EmployeeViewModel, Picture, long>(
                  propertyExpression: (EmployeeViewModel x) => x.LookUpPictures,
                  getRepositoryFunc: x => x.Pictures);
            }
        }

        /// <summary>
		/// The view model that contains a look-up collection of Probations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Probation> LookUpProbations {
            get { return GetLookUpEntitiesViewModel((EmployeeViewModel x) => x.LookUpProbations, x => x.Probations); }
        }

        /// <summary>
        /// The view model for the EmployeeOwnedTasks detail collection.
        /// </summary>
        public CollectionViewModelBase<EmployeeTask, EmployeeTask, long, IDevAVDbUnitOfWork> EmployeeOwnedTasksDetails {
            get {
                return GetDetailsCollectionViewModel<EmployeeViewModel, EmployeeTask, long, long?>(
                    propertyExpression: (EmployeeViewModel x) => x.EmployeeOwnedTasksDetails,
                    getRepositoryFunc: x => x.Tasks,
                    foreignKeyExpression: x => x.OwnerId,
                    navigationExpression: x => x.Owner);
            }
        }

        /// <summary>
        /// The view model for the EmployeeEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, long, IDevAVDbUnitOfWork> EmployeeEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel<EmployeeViewModel, Evaluation, long, long?>(
                    propertyExpression: (EmployeeViewModel x) => x.EmployeeEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.EmployeeId,
                    navigationExpression: x => x.Employee);
            }
        }
    }
}
