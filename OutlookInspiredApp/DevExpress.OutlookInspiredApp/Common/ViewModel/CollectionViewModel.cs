using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.DevAV.Common.Utils;
using DevExpress.Mvvm.ViewModel;
using DevExpress.Mvvm.DataModel;

namespace DevExpress.DevAV.Common.ViewModel {
    /// <summary>
    /// The base class for a POCO view models exposing a collection of entities of a given type and CRUD operations against these entities.
    /// This is a partial class that provides extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public partial class CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> : CollectionViewModel<TEntity, TEntity, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of CollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="canCreateNewEntity">A function that is called before an attempt to create a new entity is made. This parameter is used together with the newEntityInitializer parameter.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        public static CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> CreateCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            Action<TEntity> newEntityInitializer = null,
            Func<bool> canCreateNewEntity = null,
            bool ignoreSelectEntityMessage = false,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual) {
            return ViewModelSource.Create(() => new CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, canCreateNewEntity, ignoreSelectEntityMessage, unitOfWorkPolicy));
        }

        /// <summary>
        /// Initializes a new instance of the CollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="canCreateNewEntity">A function that is called before an attempt to create a new entity is made. This parameter is used together with the newEntityInitializer parameter.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        protected CollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            Action<TEntity> newEntityInitializer = null,
            Func<bool> canCreateNewEntity = null,
            bool ignoreSelectEntityMessage = false,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, canCreateNewEntity, ignoreSelectEntityMessage, unitOfWorkPolicy) {
        }
    }

    /// <summary>
    /// The base class for a POCO view models exposing a collection of entities of a given type and CRUD operations against these entities.
    /// This is a partial class that provides extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">A repository entity type.</typeparam>
    /// <typeparam name="TProjection">A projection entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public partial class CollectionViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork> : CollectionViewModelBase<TEntity, TProjection, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TProjection : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of CollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="canCreateNewEntity">A function that is called before an attempt to create a new entity is made. This parameter is used together with the newEntityInitializer parameter.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        public static CollectionViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork> CreateProjectionCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            Action<TEntity> newEntityInitializer = null,
            Func<bool> canCreateNewEntity = null,
            bool ignoreSelectEntityMessage = false,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual) {
            return ViewModelSource.Create(() => new CollectionViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, canCreateNewEntity, ignoreSelectEntityMessage, unitOfWorkPolicy));
        }

        /// <summary>
        /// Initializes a new instance of the CollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="canCreateNewEntity">A function that is called before an attempt to create a new entity is made. This parameter is used together with the newEntityInitializer parameter.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        protected CollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            Action<TEntity> newEntityInitializer = null,
            Func<bool> canCreateNewEntity = null,
            bool ignoreSelectEntityMessage = false,
            UnitOfWorkPolicy unitOfWorkPolicy = UnitOfWorkPolicy.Individual
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, canCreateNewEntity, ignoreSelectEntityMessage, unitOfWorkPolicy) {
        }
    }   
}