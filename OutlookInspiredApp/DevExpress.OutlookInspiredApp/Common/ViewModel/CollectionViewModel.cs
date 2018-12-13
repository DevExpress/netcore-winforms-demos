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
    /// The base class for a POCO view models exposing a colection of entities of a given type and CRUD operations against these entities.
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
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        public static CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> CreateCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            Action<TEntity> newEntityInitializer = null,
			bool ignoreSelectEntityMessage = false) {
            return ViewModelSource.Create(() => new CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, ignoreSelectEntityMessage));
        }

        /// <summary>
        /// Initializes a new instance of the CollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">An optional parameter that provides a LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        protected CollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TEntity>> projection = null,
            Action<TEntity> newEntityInitializer = null,
			bool ignoreSelectEntityMessage = false
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, ignoreSelectEntityMessage) {
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
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        public static CollectionViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork> CreateProjectionCollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            Action<TEntity> newEntityInitializer = null,
            bool ignoreSelectEntityMessage = false) {
            return ViewModelSource.Create(() => new CollectionViewModel<TEntity, TProjection, TPrimaryKey, TUnitOfWork>(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, ignoreSelectEntityMessage));
        }

        /// <summary>
        /// Initializes a new instance of the CollectionViewModel class.
        /// This constructor is declared protected to avoid an undesired instantiation of the CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="ignoreSelectEntityMessage">An optional parameter that used to specify that the selected entity should not be managed by PeekCollectionViewModel.</param>
        protected CollectionViewModel(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            Action<TEntity> newEntityInitializer = null,
			bool ignoreSelectEntityMessage = false
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection, newEntityInitializer, ignoreSelectEntityMessage) {
        }
    }

    /// <summary>
    /// The base class for POCO view models exposing a collection of entities of a given type and CRUD operations against these entities.
    /// It is not recommended to inherit directly from this class. Use the CollectionViewModel class instead.
    /// </summary>
    /// <typeparam name="TEntity">A repository entity type.</typeparam>
    /// <typeparam name="TProjection">A projection entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    public abstract class CollectionViewModelBase<TEntity, TProjection, TPrimaryKey, TUnitOfWork> : ReadOnlyCollectionViewModel<TEntity, TProjection, TUnitOfWork>
        where TEntity : class
        where TProjection : class
        where TUnitOfWork : IUnitOfWork {

        EntitiesChangeTracker<TPrimaryKey> ChangeTrackerWithKey { get { return (EntitiesChangeTracker<TPrimaryKey>)ChangeTracker; } }
        readonly Action<TEntity> newEntityInitializer;
        IRepository<TEntity, TPrimaryKey> Repository { get { return (IRepository<TEntity, TPrimaryKey>)ReadOnlyRepository; } }
        
        /// <summary>
        /// Initializes a new instance of the CollectionViewModelBase class.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns a repository representing entities of the given type.</param>
        /// <param name="projection">A LINQ function used to customize a query for entities. The parameter, for example, can be used for sorting data and/or for projecting data to a custom type that does not match the repository entity type.</param>
        /// <param name="newEntityInitializer">A function to initialize a new entity. This parameter is used in the detail collection view models when creating a single object view model for a new entity.</param>
        /// <param name="ignoreSelectEntityMessage">A parameter used to specify whether the selected entity should be managed by PeekCollectionViewModel.</param>
        protected CollectionViewModelBase(
            IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory,
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection,
            Action<TEntity> newEntityInitializer,
			bool ignoreSelectEntityMessage
            ) : base(unitOfWorkFactory, getRepositoryFunc, projection) {
            VerifyProjectionType();
            this.newEntityInitializer = newEntityInitializer;
			this.ignoreSelectEntityMessage = ignoreSelectEntityMessage;
			if(!this.IsInDesignMode())
				RegisterSelectEntityMessage();
        }

        /// <summary>
        /// Creates and shows a document that contains a single object view model for new entity.
        /// Since CollectionViewModelBase is a POCO view model, an the instance of this class will also expose the NewCommand property that can be used as a binding source in views.
        /// </summary>
        public virtual void New() {
            GetDocumentManagerService().ShowNewEntityDocument(this, newEntityInitializer);
        }

        /// <summary>
        /// Creates and shows a document that contains a single object view model for the existing entity.
        /// Since CollectionViewModelBase is a POCO view model, an the instance of this class will also expose the EditCommand property that can be used as a binding source in views.
        /// </summary>
        /// <param name="projectionEntity">Entity to edit.</param>
        public virtual void Edit(TProjection projectionEntity) {
            if(Repository.IsDetached(projectionEntity))
                return;
            TPrimaryKey primaryKey = Repository.GetProjectionPrimaryKey(projectionEntity);
            int index = Entities.IndexOf(projectionEntity);
            projectionEntity = ChangeTrackerWithKey.FindActualProjectionByKey(primaryKey);
            if(index >= 0) {
                if(projectionEntity == null)
                    Entities.RemoveAt(index);
                else
                    Entities[index] = projectionEntity;
            }
            if(projectionEntity == null) {
                DestroyDocument(GetDocumentManagerService().FindEntityDocument<TEntity, TPrimaryKey>(primaryKey));
                return;
            }
            GetDocumentManagerService().ShowExistingEntityDocument<TEntity, TPrimaryKey>(this, primaryKey);
        }

        /// <summary>
        /// Determines whether an entity can be edited.
        /// Since CollectionViewModelBase is a POCO view model, this method will be used as a CanExecute callback for EditCommand.
        /// </summary>
        /// <param name="projectionEntity">An entity to edit.</param>
        public bool CanEdit(TProjection projectionEntity) {
            return projectionEntity != null && !IsLoading;
        }

        /// <summary>
        /// Deletes a given entity from the repository and saves changes if confirmed by the user.
        /// Since CollectionViewModelBase is a POCO view model, an the instance of this class will also expose the DeleteCommand property that can be used as a binding source in views.
        /// </summary>
        /// <param name="projectionEntity">An entity to edit.</param>
        public virtual void Delete(TProjection projectionEntity) {
            if(MessageBoxService.ShowMessage(string.Format(CommonResources.Confirmation_Delete, typeof(TEntity).Name), CommonResources.Confirmation_Caption, MessageButton.YesNo) != MessageResult.Yes)
                return;
            try {
                Entities.Remove(projectionEntity);
                TPrimaryKey primaryKey = Repository.GetProjectionPrimaryKey(projectionEntity);
                TEntity entity = Repository.Find(primaryKey);
                if(entity != null) {
					OnBeforeEntityDeleted(primaryKey, entity);
                    Repository.Remove(entity);
                    Repository.UnitOfWork.SaveChanges();
					OnEntityDeleted(primaryKey, entity);
                }
            } catch (DbException e) {
                Refresh();
                MessageBoxService.ShowMessage(e.ErrorMessage, e.ErrorCaption, MessageButton.OK, MessageIcon.Error);
            }
        }

        /// <summary>
        /// Determines whether an entity can be deleted.
        /// Since CollectionViewModelBase is a POCO view model, this method will be used as a CanExecute callback for DeleteCommand.
        /// </summary>
        /// <param name="projectionEntity">An entity to edit.</param>
        public virtual bool CanDelete(TProjection projectionEntity) {
            return projectionEntity != null && !IsLoading;
        }

        /// <summary>
        /// Saves the given entity.
        /// Since CollectionViewModelBase is a POCO view model, the instance of this class will also expose the SaveCommand property that can be used as a binding source in views.
        /// </summary>
        /// <param name="projectionEntity">An entity to save.</param>
        [Display(AutoGenerateField = false)]
        public virtual void Save(TProjection projectionEntity) {
            TPrimaryKey primaryKey = Repository.GetProjectionPrimaryKey(projectionEntity);
            TEntity entity = Repository.Find(primaryKey);
            if(typeof(TProjection) != typeof(TEntity))
                ApplyProjectionPropertiesToEntity(projectionEntity, entity);
            try {
                OnBeforeEntitySaved(primaryKey, entity);
                Repository.UnitOfWork.SaveChanges();
                OnEntitySaved(primaryKey, entity);
            } catch (DbException e) {
                MessageBoxService.ShowMessage(e.ErrorMessage, e.ErrorCaption, MessageButton.OK, MessageIcon.Error);
            }
        }

        /// <summary>
        /// Determines whether entity local changes can be saved.
        /// Since CollectionViewModelBase is a POCO view model, this method will be used as a CanExecute callback for SaveCommand.
        /// </summary>
        /// <param name="projectionEntity">An entity to save.</param>
        public virtual bool CanSave(TProjection projectionEntity) {
            return projectionEntity != null && !IsLoading;
        }

        /// <summary>
        /// Notifies that SelectedEntity has been changed by raising the PropertyChanged event.
        /// Since CollectionViewModelBase is a POCO view model, an the instance of this class will also expose the UpdateSelectedEntityCommand property that can be used as a binding source in views.
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual void UpdateSelectedEntity() {
            this.RaisePropertyChanged(x => x.SelectedEntity);
        }

        /// <summary>
        /// Closes the corresponding view.
        /// Since CollectionViewModelBase is a POCO view model, an the instance of this class will also expose the CloseCommand property that can be used as a binding source in views.
        /// </summary>
        [Display(AutoGenerateField = false)]
        public void Close() {
            if(DocumentOwner != null)
                DocumentOwner.Close(this);
        }

        protected IMessageBoxService MessageBoxService { get { return this.GetRequiredService<IMessageBoxService>(); } }

        protected virtual IDocumentManagerService GetDocumentManagerService() { return this.GetService<IDocumentManagerService>(); }

        protected virtual void OnBeforeEntityDeleted(TPrimaryKey primaryKey, TEntity entity) { }

        protected virtual void OnEntityDeleted(TPrimaryKey primaryKey, TEntity entity) {
            Messenger.Default.Send(new EntityMessage<TEntity, TPrimaryKey>(primaryKey, EntityMessageType.Deleted));
        }

        protected override Func<TProjection> GetSelectedEntityCallback() {
            var entity = SelectedEntity;
            return () => FindLocalProjectionWithSameKey(entity);
        }

        TProjection FindLocalProjectionWithSameKey(TProjection projectionEntity) {
            bool primaryKeyAvailable = projectionEntity != null && Repository.ProjectionHasPrimaryKey(projectionEntity);
            return primaryKeyAvailable ? ChangeTrackerWithKey.FindLocalProjectionByKey(Repository.GetProjectionPrimaryKey(projectionEntity)) : null;
        }

        protected virtual void OnBeforeEntitySaved(TPrimaryKey primaryKey, TEntity entity) { }

        protected virtual void OnEntitySaved(TPrimaryKey primaryKey, TEntity entity) {
            Messenger.Default.Send(new EntityMessage<TEntity, TPrimaryKey>(primaryKey, EntityMessageType.Changed));
        }

        protected virtual void ApplyProjectionPropertiesToEntity(TProjection projectionEntity, TEntity entity) {
            throw new NotImplementedException("Override this method in the collection view model class and apply projection properties to the entity so that it can be correctly saved by unit of work.");
        }

        protected override void OnSelectedEntityChanged() {
            base.OnSelectedEntityChanged();
            UpdateCommands();
        }

        protected override void RestoreSelectedEntity(TProjection existingProjectionEntity, TProjection newProjectionEntity) {
            base.RestoreSelectedEntity(existingProjectionEntity, newProjectionEntity);
            if(ReferenceEquals(SelectedEntity, existingProjectionEntity))
                SelectedEntity = newProjectionEntity;
        }

        protected override void OnIsLoadingChanged() {
            base.OnIsLoadingChanged();
            UpdateCommands();
			if(!IsLoading)
				RequestSelectedEntity();
        }

        void UpdateCommands() {
            TProjection projectionEntity = null;
            this.RaiseCanExecuteChanged(x => x.Edit(projectionEntity));
            this.RaiseCanExecuteChanged(x => x.Delete(projectionEntity));
            this.RaiseCanExecuteChanged(x => x.Save(projectionEntity));
        }

        protected void DestroyDocument(IDocument document) {
            if(document != null)
                document.Close();
        }

        protected IRepository<TEntity, TPrimaryKey> CreateRepository() {
            return (IRepository<TEntity, TPrimaryKey>)CreateReadOnlyRepository();
        }

        protected override IEntitiesChangeTracker CreateEntitiesChangeTracker() {
            return new EntitiesChangeTracker<TPrimaryKey>(this);
        }

        void VerifyProjectionType() {
            //string primaryKeyPropertyName = CreateRepository().GetPrimaryKeyExpression.Name;
            //if (TypeDescriptor.GetProperties(typeof(TProjection))[primaryKeyPropertyName] == null)
            //    throw new ArgumentException(string.Format("Projection type {0} should have primary key property {1}", typeof(TProjection).Name, primaryKeyPropertyName), "TProjection");
        }

		#region SelectEntityMessage
        protected class SelectEntityMessage {
            public SelectEntityMessage(TPrimaryKey primaryKey) {
                PrimaryKey = primaryKey;
            }
            public TPrimaryKey PrimaryKey { get; private set; }
        }

        protected class SelectedEntityRequest { }

        readonly bool ignoreSelectEntityMessage;

        void RegisterSelectEntityMessage() {
            if(!ignoreSelectEntityMessage)
				Messenger.Default.Register<SelectEntityMessage>(this, x => OnSelectEntityMessage(x));
        }

		void RequestSelectedEntity() {
			if(!ignoreSelectEntityMessage)
				Messenger.Default.Send(new SelectedEntityRequest());
		}

        void OnSelectEntityMessage(SelectEntityMessage message) {
            if(!IsLoaded)
                return;
            var projectionEntity = ChangeTrackerWithKey.FindActualProjectionByKey(message.PrimaryKey);
			if(projectionEntity == null) {
				FilterExpression = null;
				projectionEntity = ChangeTrackerWithKey.FindActualProjectionByKey(message.PrimaryKey);
			}
			SelectedEntity = projectionEntity;
        }
        #endregion
    }

    /// <summary>
    /// Provides the extension methods that are used to implement the IDocumentManagerService interface.
    /// </summary>
    public static class DocumentManagerServiceExtensions {

        /// <summary>
        /// Creates and shows a document containing a single object view model for the existing entity.
        /// </summary>
        /// <param name="documentManagerService">An instance of the IDocumentManager interface used to create and show the document.</param>
        /// <param name="parentViewModel">An object that is passed to the view model of the created view.</param>
        /// <param name="primaryKey">An entity primary key.</param>
        public static void ShowExistingEntityDocument<TEntity, TPrimaryKey>(this IDocumentManagerService documentManagerService, object parentViewModel, TPrimaryKey primaryKey) {
            IDocument document = FindEntityDocument<TEntity, TPrimaryKey>(documentManagerService, primaryKey) ?? CreateDocument<TEntity>(documentManagerService, primaryKey, parentViewModel);
            if(document != null)
                document.Show();
        }

        /// <summary>
        /// Creates and shows a document containing a single object view model for new entity.
        /// </summary>
        /// <param name="documentManagerService">An instance of the IDocumentManager interface used to create and show the document.</param>
        /// <param name="parentViewModel">An object that is passed to the view model of the created view.</param>
        /// <param name="newEntityInitializer">An optional parameter that provides a function that initializes a new entity.</param>
        public static void ShowNewEntityDocument<TEntity>(this IDocumentManagerService documentManagerService, object parentViewModel, Action<TEntity> newEntityInitializer = null) {
            IDocument document = CreateDocument<TEntity>(documentManagerService, newEntityInitializer != null ? newEntityInitializer : x => DefaultEntityInitializer(x), parentViewModel);
            if(document != null)
                document.Show();
        }

        /// <summary>
        /// Searches for a document that contains a single object view model editing entity with a specified primary key.
        /// </summary>
        /// <param name="documentManagerService">An instance of the IDocumentManager interface used to find a document.</param>
        /// <param name="primaryKey">An entity primary key.</param>
        public static IDocument FindEntityDocument<TEntity, TPrimaryKey>(this IDocumentManagerService documentManagerService, TPrimaryKey primaryKey) {
            if(documentManagerService == null)
                return null;
            foreach(IDocument document in documentManagerService.Documents) {
                ISingleObjectViewModel<TEntity, TPrimaryKey> entityViewModel = document.Content as ISingleObjectViewModel<TEntity, TPrimaryKey>;
                if(entityViewModel != null && object.Equals(entityViewModel.PrimaryKey, primaryKey))
                    return document;
            }
            return null;
        }

        static void DefaultEntityInitializer<TEntity>(TEntity entity) { }

        static IDocument CreateDocument<TEntity>(IDocumentManagerService documentManagerService, object parameter, object parentViewModel) {
            if(documentManagerService == null)
                return null;
            return documentManagerService.CreateDocument(typeof(TEntity).Name + "View", parameter, parentViewModel);
        }
    }
}