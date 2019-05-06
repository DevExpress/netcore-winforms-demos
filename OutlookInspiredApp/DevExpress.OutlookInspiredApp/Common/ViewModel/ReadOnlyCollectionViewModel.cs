using System;
using System.Linq;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;

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
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual) {
            return ViewModelSource.Create(() => new ReadOnlyCollectionViewModel<TEntity, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, unitOfWorkPolicy));
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
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual)
            : base(unitOfWorkFactory, getRepositoryFunc, projection, unitOfWorkPolicy) {
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
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual) {
            return ViewModelSource.Create(() => new ReadOnlyCollectionViewModel<TEntity, TProjection, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, unitOfWorkPolicy));
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
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual)
            : base(unitOfWorkFactory, getRepositoryFunc, projection, unitOfWorkPolicy) {
        }
    }
}