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
using DevExpress.Mvvm.DataModel;

namespace DevExpress.DevAV.Common.ViewModel {
    /// <summary>
    /// A POCO view model exposing a read-only collection of entities of a given type. It is designed for quick navigation between collection views.
    /// This is a partial class that provides an extension point to add custom properties, commands and override methods without modifying the auto-generated code.
    /// </summary>
    /// <typeparam name="TNavigationToken">A navigation token type.</typeparam>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public partial class PeekCollectionViewModel<TNavigationToken, TEntity, TPrimaryKey, TUnitOfWork> : CollectionViewModelBase<TEntity, TEntity, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        /// <summary>
        /// Creates a new instance of PeekCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="navigationToken">Identifies the module that is the navigation target.</param>
        /// <param name="unitOfWorkFactory">A factory that is used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of a given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        public static PeekCollectionViewModel<TNavigationToken, TEntity, TPrimaryKey, TUnitOfWork> Create(
            TNavigationToken navigationToken,
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null) {
            return ViewModelSource.Create(() => new PeekCollectionViewModel<TNavigationToken, TEntity, TPrimaryKey, TUnitOfWork>(navigationToken, unitOfWorkFactory, getRepositoryFunc, projection));
        }

        TNavigationToken navigationToken;
		TEntity pickedEntity;

        /// <summary>
        /// Initializes a new instance of the PeekCollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the PeekCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="navigationToken">Identifies the module that is the navigation target.</param>
        /// <param name="unitOfWorkFactory">A factory that is used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of a given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        protected PeekCollectionViewModel(
            TNavigationToken navigationToken,
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection, null, true) {
            this.navigationToken = navigationToken;
        }

        /// <summary>
        /// Navigates to the corresponding collection view and selects the given entity.
        /// Since PeekCollectionViewModel is a POCO view model, an instance of this class will also expose the NavigateCommand property that can be used as a binding source in views.
        /// </summary>
        /// <param name="projectionEntity">An entity to select within the collection view.</param>
        [Display(AutoGenerateField = false)]
        public void Navigate(TEntity projectionEntity) {
			pickedEntity = projectionEntity;
			SendSelectEntityMessage();
            Messenger.Default.Send(new NavigateMessage<TNavigationToken>(navigationToken), navigationToken);
        }

        /// <summary>
        /// Determines if a navigation to corresponding collection view can be performed.
        /// Since PeekCollectionViewModel is a POCO view model, this method will be used as a CanExecute callback for NavigateCommand.
        /// </summary>
        /// <param name="projectionEntity">An entity to select in the collection view.</param>
        public bool CanNavigate(TEntity projectionEntity) {
            return projectionEntity != null;
        }

        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            Messenger.Default.Register<SelectedEntityRequest>(this, x => SendSelectEntityMessage());
        }

        void SendSelectEntityMessage() {
            if(IsLoaded && pickedEntity != null)
                Messenger.Default.Send(new SelectEntityMessage(CreateRepository().GetProjectionPrimaryKey(pickedEntity)));
		}
    }
}