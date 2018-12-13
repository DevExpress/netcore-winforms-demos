using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.DevAV.Common.Utils;
using DevExpress.Mvvm.DataModel;

namespace DevExpress.DevAV.Common.ViewModel {
    /// <summary>
    /// The base class for POCO view models exposing a read-only collection of entities of a given type. 
    /// This is a partial class that provides the extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public partial class ReadOnlyCollectionViewModel<TEntity, TUnitOfWork> : ReadOnlyCollectionViewModel<TEntity, TEntity, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of ReadOnlyCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        public static ReadOnlyCollectionViewModel<TEntity, TUnitOfWork> CreateReadOnlyCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null) {
            return ViewModelSource.Create(() => new ReadOnlyCollectionViewModel<TEntity, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection));
        }

        /// <summary>
        /// Initializes a new instance of the ReadOnlyCollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the PeekCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        protected ReadOnlyCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null)
            : base(unitOfWorkFactory, getRepositoryFunc, projection) {
        }
    }

    /// <summary>
    /// The base class for POCO view models exposing a read-only collection of entities of a given type. 
    /// This is a partial class that provides the extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">A repository entity type.</typeparam>
    /// <typeparam name="TProjection">A projection entity type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public partial class ReadOnlyCollectionViewModel<TEntity, TProjection, TUnitOfWork> : ReadOnlyCollectionViewModelBase<TEntity, TProjection, TUnitOfWork>
        where TEntity : class
        where TProjection : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of ReadOnlyCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns the repository representing entities of a given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        public static ReadOnlyCollectionViewModel<TEntity, TProjection, TUnitOfWork> CreateReadOnlyProjectionCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection) {
            return ViewModelSource.Create(() => new ReadOnlyCollectionViewModel<TEntity, TProjection, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection));
        }

        /// <summary>
        /// Initializes a new instance of the ReadOnlyCollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the PeekCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns the repository representing entities of a given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        protected ReadOnlyCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, 
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection)
            : base(unitOfWorkFactory, getRepositoryFunc, projection) {
        }
    }

    /// <summary>
    /// The base class for POCO view models exposing a read-only collection of entities of a given type. 
    /// It is not recommended to inherit directly from this class. Use the ReadOnlyCollectionViewModel class instead.
    /// </summary>
    /// <typeparam name="TEntity">A repository entity type.</typeparam>
    /// <typeparam name="TProjection">A projection entity type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    [POCOViewModel]
    public abstract class ReadOnlyCollectionViewModelBase<TEntity, TProjection, TUnitOfWork> : EntitiesViewModel<TEntity, TProjection, TUnitOfWork>
        where TEntity : class
        where TProjection : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the ReadOnlyCollectionViewModelBase class.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns the repository representing entities of a given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        protected ReadOnlyCollectionViewModelBase(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, 
            Func<TUnitOfWork, IReadOnlyRepository<TEntity>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection) {
        }

        /// <summary>
        /// The selected enity.
        /// Since ReadOnlyCollectionViewModelBase is a POCO view model, this property will raise INotifyPropertyChanged.PropertyEvent when modified so it can be used as a binding source in views.
        /// </summary>
        public virtual TProjection SelectedEntity { get; set; }

        /// <summary>
        /// The lambda expression used to filter which entities will be loaded locally from the unit of work.
        /// Since ReadOnlyCollectionViewModelBase is a POCO view model, this property will raise INotifyPropertyChanged.PropertyEvent when modified so it can be used as a binding source in views.
        /// </summary>
        public virtual Expression<Func<TEntity, bool>> FilterExpression { get; set; }

        /// <summary>
        /// Reloads entities.
        /// Since CollectionViewModelBase is a POCO view model, an instance of this class will also expose the RefreshCommand property that can be used as a binding source in views.
        /// </summary>
        public virtual void Refresh() {
            LoadEntities(false);
        }

        /// <summary>
        /// Determines whether entities can be reloaded.
        /// Since CollectionViewModelBase is a POCO view model, this method will be used as a CanExecute callback for RefreshCommand.
        /// </summary>
        public bool CanRefresh() {
            return !IsLoading;
        }

        protected override void OnEntitiesAssigned(Func<TProjection> getSelectedEntityCallback) {
            base.OnEntitiesAssigned(getSelectedEntityCallback);
            SelectedEntity = getSelectedEntityCallback() ?? Entities.FirstOrDefault();
        }

        protected override Func<TProjection> GetSelectedEntityCallback() {
            int selectedItemIndex = Entities.IndexOf(SelectedEntity);
            return () => (selectedItemIndex >= 0 && selectedItemIndex < Entities.Count) ? Entities[selectedItemIndex] : null;
        }

        protected override void OnIsLoadingChanged() {
            base.OnIsLoadingChanged();
            this.RaiseCanExecuteChanged(x => x.Refresh());
        }

        protected virtual void OnSelectedEntityChanged() { }

        protected virtual void OnFilterExpressionChanged() {
            if(IsLoaded || IsLoading)
                LoadEntities(true);
        }

        protected override Expression<Func<TEntity, bool>> GetFilterExpression() {
            return FilterExpression;
        }
    }
}