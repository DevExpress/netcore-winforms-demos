using System;
using System.Linq;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.Common.ViewModel {
    /// <summary>
    /// The base class for POCO view models exposing a single entity of a given type and CRUD operations against this entity.
    /// This is a partial class that provides the extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public abstract partial class SingleObjectViewModel<TEntity, TPrimaryKey, TUnitOfWork> : SingleObjectViewModelBase<TEntity, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the SingleObjectViewModel class.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create the unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns the repository representing entities of a given type.</param>
        /// <param name="getEntityDisplayNameFunc">An optional parameter that provides a function to obtain the display text for a given entity. If ommited, the primary key value is used as a display text.</param>
        protected SingleObjectViewModel(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc, Func<TEntity, object> getEntityDisplayNameFunc = null)
            : base(unitOfWorkFactory, getRepositoryFunc, getEntityDisplayNameFunc) {
        }
    }
}