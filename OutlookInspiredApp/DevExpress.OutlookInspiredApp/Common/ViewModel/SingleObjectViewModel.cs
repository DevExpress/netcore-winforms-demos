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

    /// <summary>
    /// The base class for POCO view models exposing a single entity of a given type and CRUD operations against this entity. 
    /// It is not recommended to inherit directly from this class. Use the SingleObjectViewModel class instead.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">A primary key value type.</typeparam>
    /// <typeparam name="TUnitOfWork">A unit of work type.</typeparam>
    [POCOViewModel]
    public abstract class SingleObjectViewModelBase<TEntity, TPrimaryKey, TUnitOfWork> : ISingleObjectViewModel<TEntity, TPrimaryKey>, ISupportParameter, IDocumentContent
        where TEntity : class
        where TUnitOfWork : IUnitOfWork {

        object title;
        protected readonly Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc;
        protected readonly Func<TEntity, object> getEntityDisplayNameFunc;
        Action<TEntity> entityInitializer;
        bool isEntityNewAndUnmodified;
        readonly Dictionary<string, IDocumentContent> lookUpViewModels = new Dictionary<string, IDocumentContent>();

        /// <summary>
        /// Initializes a new instance of the SingleObjectViewModelBase class.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create the unit of work instance.</param>
        /// <param name="getRepositoryFunc">A function that returns repository representing entities of a given type.</param>
        /// <param name="getEntityDisplayNameFunc">An optional parameter that provides a function to obtain the display text for a given entity. If ommited, the primary key value is used as a display text.</param>
        protected SingleObjectViewModelBase(IUnitOfWorkFactory<TUnitOfWork> unitOfWorkFactory, Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc, Func<TEntity, object> getEntityDisplayNameFunc) {
            UnitOfWorkFactory = unitOfWorkFactory;
            this.getRepositoryFunc = getRepositoryFunc;
            this.getEntityDisplayNameFunc = getEntityDisplayNameFunc;
            UpdateUnitOfWork();
            if(this.IsInDesignMode())
                this.Entity = this.Repository.FirstOrDefault();
            else
                OnInitializeInRuntime();
        }

        /// <summary>
        /// The display text for a given entity used as a title in the corresponding view.
        /// </summary>
        /// <returns></returns>
        public object Title { get { return title; } }

        /// <summary>
        /// An entity represented by this view model.
        /// Since SingleObjectViewModelBase is a POCO view model, this property will raise INotifyPropertyChanged.PropertyEvent when modified so it can be used as a binding source in views.
        /// </summary>
        /// <returns></returns>
        public virtual TEntity Entity { get; protected set; }

        /// <summary>
        /// Updates the Title property value and raises CanExecute changed for relevant commands.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the UpdateCommand property that can be used as a binding source in views.
        /// </summary>
        [Display(AutoGenerateField = false)]
        public void Update() {
			isEntityNewAndUnmodified = false;
            UpdateTitle();
            UpdateCommands();
        }

        /// <summary>
        /// Saves changes in the underlying unit of work.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the SaveCommand property that can be used as a binding source in views.
        /// </summary>
        public virtual void Save() {
			SaveCore();
        }

        /// <summary>
        /// Determines whether entity has local changes that can be saved.
        /// Since SingleObjectViewModelBase is a POCO view model, this method will be used as a CanExecute callback for SaveCommand.
        /// </summary>
        public virtual bool CanSave() {
            return Entity != null && !HasValidationErrors() && NeedSave();
        }

        /// <summary>
        /// Saves changes in the underlying unit of work and closes the corresponding view.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the SaveAndCloseCommand property that can be used as a binding source in views.
        /// </summary>
        [Command(CanExecuteMethodName = "CanSave")]
        public void SaveAndClose() {
            if(SaveCore())
                Close();
        }

		/// <summary>
        /// Saves changes in the underlying unit of work and create new entity.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the SaveAndNewCommand property that can be used as a binding source in views.
        /// </summary>
        [Command(CanExecuteMethodName = "CanSave")]
        public void SaveAndNew() {
            if(SaveCore())
                CreateAndInitializeEntity(this.entityInitializer);
        }

        /// <summary>
        /// Reset entity local changes.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the ResetCommand property that can be used as a binding source in views.
        /// </summary>
		[Display(Name = "Reset Changes")]
        public void Reset() {
            MessageResult confirmationResult = MessageBoxService.ShowMessage(CommonResources.Confirmation_Reset, CommonResources.Confirmation_Caption, MessageButton.OKCancel);
            if(confirmationResult == MessageResult.OK)
                Reload();
        }

        /// <summary>
        /// Determines whether entity has local changes.
        /// Since SingleObjectViewModelBase is a POCO view model, this method will be used as a CanExecute callback for ResetCommand.
        /// </summary>
        public bool CanReset() {
            return NeedReset();
        }

        /// <summary>
        /// Deletes the entity, save changes and closes the corresponding view if confirmed by a user.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the DeleteCommand property that can be used as a binding source in views.
        /// </summary>
        public virtual void Delete() {
            if(MessageBoxService.ShowMessage(string.Format(CommonResources.Confirmation_Delete, typeof(TEntity).Name), GetConfirmationMessageTitle(), MessageButton.YesNo) != MessageResult.Yes)
                return;
            try {
                OnBeforeEntityDeleted(PrimaryKey, Entity);
                Repository.Remove(Entity);
                UnitOfWork.SaveChanges();
                TPrimaryKey primaryKeyForMessage = PrimaryKey;
				TEntity entityForMessage = Entity;
                Entity = null;
				OnEntityDeleted(primaryKeyForMessage, entityForMessage);
                Close();
            } catch (DbException e) {
                MessageBoxService.ShowMessage(e.ErrorMessage, e.ErrorCaption, MessageButton.OK, MessageIcon.Error);
            }
        }

        /// <summary>
        /// Determines whether the entity can be deleted.
        /// Since SingleObjectViewModelBase is a POCO view model, this method will be used as a CanExecute callback for DeleteCommand.
        /// </summary>
        public virtual bool CanDelete() {
            return Entity != null && !IsNew();
        }

        /// <summary>
        /// Closes the corresponding view.
        /// Since SingleObjectViewModelBase is a POCO view model, an instance of this class will also expose the CloseCommand property that can be used as a binding source in views.
        /// </summary>
        public void Close() {
            if(!TryClose())
                return;
            if(DocumentOwner != null)
                DocumentOwner.Close(this);
        }

        protected IUnitOfWorkFactory<TUnitOfWork> UnitOfWorkFactory { get; private set; }

        protected TUnitOfWork UnitOfWork { get; private set; }

        protected virtual bool SaveCore() {
            try {
                bool isNewEntity = IsNew();
                if(!isNewEntity) {
					Repository.SetPrimaryKey(Entity, PrimaryKey);
                    Repository.Update(Entity);
				}
				OnBeforeEntitySaved(PrimaryKey, Entity, isNewEntity);
                UnitOfWork.SaveChanges();
				LoadEntityByKey(Repository.GetPrimaryKey(Entity));
				OnEntitySaved(PrimaryKey, Entity, isNewEntity);
                return true;
            } catch (DbException e) {
                MessageBoxService.ShowMessage(e.ErrorMessage, e.ErrorCaption, MessageButton.OK, MessageIcon.Error);
                return false;
            }
        }

		protected virtual void OnBeforeEntitySaved(TPrimaryKey primaryKey, TEntity entity, bool isNewEntity) { }

        protected virtual void OnEntitySaved(TPrimaryKey primaryKey, TEntity entity, bool isNewEntity) {
            Messenger.Default.Send(new EntityMessage<TEntity, TPrimaryKey>(primaryKey, isNewEntity ? EntityMessageType.Added : EntityMessageType.Changed));
        }

        protected virtual void OnBeforeEntityDeleted(TPrimaryKey primaryKey, TEntity entity) { }

        protected virtual void OnEntityDeleted(TPrimaryKey primaryKey, TEntity entity) {
            Messenger.Default.Send(new EntityMessage<TEntity, TPrimaryKey>(primaryKey, EntityMessageType.Deleted));
        }

        protected virtual void OnInitializeInRuntime() {
            Messenger.Default.Register<EntityMessage<TEntity, TPrimaryKey>>(this, x => OnEntityMessage(x));
			Messenger.Default.Register<SaveAllMessage>(this, x => Save());
			Messenger.Default.Register<CloseAllMessage>(this, x => OnClosing(x));
        }

        protected virtual void OnEntityMessage(EntityMessage<TEntity, TPrimaryKey> message) {
            if(Entity == null) return;
            if(message.MessageType == EntityMessageType.Deleted && object.Equals(message.PrimaryKey, PrimaryKey))
                Close();
        }

        protected virtual void OnEntityChanged() {
			if(Entity != null && Repository.HasPrimaryKey(Entity)) {
				PrimaryKey = Repository.GetPrimaryKey(Entity);
                RefreshLookUpCollections(true);
			}
            Update();
        }

        protected IRepository<TEntity, TPrimaryKey> Repository { get { return getRepositoryFunc(UnitOfWork); } }

		protected TPrimaryKey PrimaryKey { get; private set; }

        protected IMessageBoxService MessageBoxService { get { return this.GetRequiredService<IMessageBoxService>(); } }

        protected virtual void OnParameterChanged(object parameter) {
            var initializer = parameter as Action<TEntity>;
			if(initializer != null)
				CreateAndInitializeEntity(initializer);
            else if(parameter is TPrimaryKey)
				LoadEntityByKey((TPrimaryKey)parameter);
			else
                Entity = null;
        }

        protected virtual TEntity CreateEntity() {
            return Repository.Create();
        }

		protected void Reload() {
            if(Entity == null || IsNew())
                CreateAndInitializeEntity(this.entityInitializer);
            else
                LoadEntityByKey(PrimaryKey);
        }

        protected void CreateAndInitializeEntity(Action<TEntity> entityInitializer) {
            UpdateUnitOfWork();
            this.entityInitializer = entityInitializer;
            var entity = CreateEntity();
            if(this.entityInitializer != null)
                this.entityInitializer(entity);
            Entity = entity;
            isEntityNewAndUnmodified = true;
        }

        protected void LoadEntityByKey(TPrimaryKey primaryKey) {
            UpdateUnitOfWork();
            Entity = Repository.Find(primaryKey);
        }

        void UpdateUnitOfWork() {
            UnitOfWork = UnitOfWorkFactory.CreateUnitOfWork();
        }

        void UpdateTitle() {
            if(Entity == null)
                title = null;
            else if(IsNew())
                title = GetTitleForNewEntity();
            else
                title = GetTitle(GetState() == EntityState.Modified);
            this.RaisePropertyChanged(x => x.Title);
        }

        protected virtual void UpdateCommands() {
            this.RaiseCanExecuteChanged(x => x.Save());
			this.RaiseCanExecuteChanged(x => x.SaveAndClose());
			this.RaiseCanExecuteChanged(x => x.SaveAndNew());
            this.RaiseCanExecuteChanged(x => x.Delete());
            this.RaiseCanExecuteChanged(x => x.Reset());
        }

        protected IDocumentOwner DocumentOwner { get; private set; }

        protected virtual void OnDestroy() {
            Messenger.Default.Unregister(this);
            RefreshLookUpCollections(false);
        }

        protected virtual bool TryClose() {
            if(HasValidationErrors()) {
                MessageResult warningResult = MessageBoxService.ShowMessage(CommonResources.Warning_SomeFieldsContainInvalidData, CommonResources.Warning_Caption, MessageButton.OKCancel);
                return warningResult == MessageResult.OK;
            }
            if(!NeedReset()) return true;
            MessageResult result = MessageBoxService.ShowMessage(CommonResources.Confirmation_Save, GetConfirmationMessageTitle(), MessageButton.YesNoCancel);
            if(result == MessageResult.Yes)
                return SaveCore();
            return result != MessageResult.Cancel;
        }

		protected virtual void OnClosing(CloseAllMessage message) {
            if(!message.Cancel)
                message.Cancel = !TryClose();
        }

        protected virtual string GetConfirmationMessageTitle() {
            return GetTitle();
        }

        protected bool IsNew() {
            return GetState() == EntityState.Added;
        }

        protected virtual bool NeedSave() {
            if(Entity == null)
                return false;
            EntityState state = GetState();
            return state == EntityState.Modified || state == EntityState.Added;
        }

        protected virtual bool NeedReset() {
			return NeedSave() && !isEntityNewAndUnmodified;
        }

        protected virtual bool HasValidationErrors() {
			IDataErrorInfo dataErrorInfo = Entity as IDataErrorInfo;
            return dataErrorInfo != null && IDataErrorInfoHelper.HasErrors(dataErrorInfo);
		}

        string GetTitle(bool entityModified) {
			return GetTitle() + (entityModified ? CommonResources.Entity_Changed : string.Empty);
        }

        protected virtual string GetTitleForNewEntity() {
            return typeof(TEntity).Name + CommonResources.Entity_New;
        }

        protected virtual string GetTitle() {
            return (typeof(TEntity).Name + " - " + Convert.ToString(getEntityDisplayNameFunc != null ? getEntityDisplayNameFunc(Entity) : PrimaryKey))
			.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
        }

        protected EntityState GetState() {
            try {
                return Repository.GetState(Entity);
            } catch(InvalidOperationException) {
                Repository.SetPrimaryKey(Entity, PrimaryKey);
                return Repository.GetState(Entity);
            }

        }

        #region look up and detail view models
        protected virtual void RefreshLookUpCollections(bool raisePropertyChanged) {
            var values = lookUpViewModels.ToArray();
            lookUpViewModels.Clear();
            foreach(var item in values) {
                item.Value.OnDestroy();
                if(raisePropertyChanged)
                    ((IPOCOViewModel)this).RaisePropertyChanged(item.Key);
            }
        }

        protected CollectionViewModel<TDetailEntity, TDetailPrimaryKey, TUnitOfWork> GetDetailsCollectionViewModel<TViewModel, TDetailEntity, TDetailPrimaryKey, TForeignKey>(
            Expression<Func<TViewModel, CollectionViewModel<TDetailEntity, TDetailPrimaryKey, TUnitOfWork>>> propertyExpression,
            Func<TUnitOfWork, IRepository<TDetailEntity, TDetailPrimaryKey>> getRepositoryFunc,
            Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression,
            Action<TDetailEntity, TPrimaryKey> setMasterEntityKeyAction,
            Func<IRepositoryQuery<TDetailEntity>, IQueryable<TDetailEntity>> projection = null) where TDetailEntity : class {

            return GetCollectionViewModelCore<CollectionViewModel<TDetailEntity, TDetailPrimaryKey, TUnitOfWork>, TDetailEntity, TDetailEntity, TForeignKey>(propertyExpression, foreignKeyExpression,
                () => CollectionViewModel<TDetailEntity, TDetailPrimaryKey, TUnitOfWork>.CreateCollectionViewModel(UnitOfWorkFactory, getRepositoryFunc, projection, CreateForeignKeyPropertyInitializer(setMasterEntityKeyAction, PrimaryKey), true));
        }

        protected CollectionViewModel<TDetailEntity, TDetailProjection, TDetailPrimaryKey, TUnitOfWork> GetDetailProjectionsCollectionViewModel<TViewModel, TDetailEntity, TDetailProjection, TDetailPrimaryKey, TForeignKey>(
            Expression<Func<TViewModel, CollectionViewModel<TDetailEntity, TDetailProjection, TDetailPrimaryKey, TUnitOfWork>>> propertyExpression,
            Func<TUnitOfWork, IRepository<TDetailEntity, TDetailPrimaryKey>> getRepositoryFunc,
            Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression,
            Action<TDetailEntity, TPrimaryKey> setMasterEntityKeyAction,
            Func<IRepositoryQuery<TDetailEntity>, IQueryable<TDetailProjection>> projection = null) where TDetailEntity : class where TDetailProjection : class {

            return GetCollectionViewModelCore<CollectionViewModel<TDetailEntity, TDetailProjection, TDetailPrimaryKey, TUnitOfWork>, TDetailEntity, TDetailProjection, TForeignKey>(propertyExpression, foreignKeyExpression,
                () => CollectionViewModel<TDetailEntity, TDetailProjection, TDetailPrimaryKey, TUnitOfWork>.CreateProjectionCollectionViewModel(UnitOfWorkFactory, getRepositoryFunc, projection, CreateForeignKeyPropertyInitializer(setMasterEntityKeyAction, PrimaryKey), true));
        }

        protected ReadOnlyCollectionViewModel<TDetailEntity, TUnitOfWork> GetReadOnlyDetailsCollectionViewModel<TViewModel, TDetailEntity, TForeignKey>(
            Expression<Func<TViewModel, ReadOnlyCollectionViewModel<TDetailEntity, TDetailEntity, TUnitOfWork>>> propertyExpression,
            Func<TUnitOfWork, IReadOnlyRepository<TDetailEntity>> getRepositoryFunc,
            Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression,
            Func<IRepositoryQuery<TDetailEntity>, IQueryable<TDetailEntity>> projection = null) where TDetailEntity : class {

            return GetCollectionViewModelCore<ReadOnlyCollectionViewModel<TDetailEntity, TUnitOfWork>, TDetailEntity, TDetailEntity, TForeignKey>(propertyExpression, foreignKeyExpression,
                () => ReadOnlyCollectionViewModel<TDetailEntity, TUnitOfWork>.CreateReadOnlyCollectionViewModel(UnitOfWorkFactory, getRepositoryFunc, projection));
        }

        protected ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork> GetReadOnlyDetailProjectionsCollectionViewModel<TViewModel, TDetailEntity, TDetailProjection, TForeignKey>(
            Expression<Func<TViewModel, ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork>>> propertyExpression,
            Func<TUnitOfWork, IReadOnlyRepository<TDetailEntity>> getRepositoryFunc,
            Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression,
            Func<IRepositoryQuery<TDetailEntity>, IQueryable<TDetailProjection>> projection) where TDetailEntity : class where TDetailProjection : class {

            return GetCollectionViewModelCore<ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork>, TDetailEntity, TDetailProjection, TForeignKey>(propertyExpression, foreignKeyExpression,
                () => ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork>.CreateReadOnlyProjectionCollectionViewModel(UnitOfWorkFactory, getRepositoryFunc, projection));
        }

        protected IEntitiesViewModel<TLookUpEntity> GetLookUpEntitiesViewModel<TViewModel, TLookUpEntity, TLookUpEntityKey>(Expression<Func<TViewModel, IEntitiesViewModel<TLookUpEntity>>> propertyExpression, Func<TUnitOfWork, IRepository<TLookUpEntity, TLookUpEntityKey>> getRepositoryFunc, Func<IRepositoryQuery<TLookUpEntity>, IQueryable<TLookUpEntity>> projection = null) where TLookUpEntity : class {
            return GetLookUpProjectionsViewModel(propertyExpression, getRepositoryFunc, projection);
        }

        protected virtual IEntitiesViewModel<TLookUpProjection> GetLookUpProjectionsViewModel<TViewModel, TLookUpEntity, TLookUpProjection, TLookUpEntityKey>(Expression<Func<TViewModel, IEntitiesViewModel<TLookUpProjection>>> propertyExpression, Func<TUnitOfWork, IRepository<TLookUpEntity, TLookUpEntityKey>> getRepositoryFunc, Func<IRepositoryQuery<TLookUpEntity>, IQueryable<TLookUpProjection>> projection) where TLookUpEntity : class where TLookUpProjection : class {
            return GetEntitiesViewModelCore<IEntitiesViewModel<TLookUpProjection>, TLookUpProjection>(propertyExpression, () => LookUpEntitiesViewModel<TLookUpEntity, TLookUpProjection, TLookUpEntityKey, TUnitOfWork>.Create(UnitOfWorkFactory, getRepositoryFunc, projection));
        }

        static Action<TDetailEntity> CreateForeignKeyPropertyInitializer<TDetailEntity, TForeignKey>(Action<TDetailEntity, TPrimaryKey> setMasterEntityKeyAction, TForeignKey masterEntityKey) where TDetailEntity : class {
            return x => setMasterEntityKeyAction(x, (TPrimaryKey)(object)masterEntityKey);
        }

        TViewModel GetCollectionViewModelCore<TViewModel, TDetailEntity, TDetailProjection, TForeignKey>(
            LambdaExpression propertyExpression,
            Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression,
            Func<TViewModel> createViewModelCallback)
            where TViewModel : ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork>
            where TDetailEntity : class
            where TDetailProjection : class {

            return GetEntitiesViewModelCore<TViewModel, TDetailProjection>(propertyExpression, 
                () => CreateAndInitializeCollectionViewModel<TViewModel, TDetailEntity, TDetailProjection, TForeignKey>(createViewModelCallback, foreignKeyExpression));
        }

        TViewModel CreateAndInitializeCollectionViewModel<TViewModel, TDetailEntity, TDetailProjection, TForeignKey>(Func<TViewModel> createViewModelCallback, Expression<Func<TDetailEntity, TForeignKey>> foreignKeyExpression)
            where TViewModel : ReadOnlyCollectionViewModel<TDetailEntity, TDetailProjection, TUnitOfWork>
            where TDetailEntity : class 
            where TDetailProjection : class {
            TViewModel lookUpViewModel = createViewModelCallback().SetParentViewModel(this);
            lookUpViewModel.FilterExpression = ExpressionHelper.GetValueEqualsExpression(foreignKeyExpression, (TForeignKey)(object)PrimaryKey);
            return lookUpViewModel;
        }

        TViewModel GetEntitiesViewModelCore<TViewModel, TDetailEntity>(LambdaExpression propertyExpression, Func<TViewModel> createViewModelCallback)
            where TViewModel : IEntitiesViewModel<TDetailEntity>
            where TDetailEntity : class {

            IDocumentContent result = null;
            string propertyName = ExpressionHelper.GetPropertyName(propertyExpression);
            if(!lookUpViewModels.TryGetValue(propertyName, out result)) {
                result = createViewModelCallback();
                lookUpViewModels[propertyName] = result;
            }
            return (TViewModel)result;
        }
        #endregion

        #region ISupportParameter
        object ISupportParameter.Parameter {
			get { return null; }
			set { OnParameterChanged(value); }
		}
        #endregion

        #region IDocumentContent
        object IDocumentContent.Title { get { return Title; } }

        void IDocumentContent.OnClose(CancelEventArgs e) {
            e.Cancel = !TryClose();
        }

        void IDocumentContent.OnDestroy() {
            OnDestroy();
        }

        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }
        #endregion

        #region ISingleObjectViewModel
        TEntity ISingleObjectViewModel<TEntity, TPrimaryKey>.Entity { get { return Entity; } }

        TPrimaryKey ISingleObjectViewModel<TEntity, TPrimaryKey>.PrimaryKey { get { return PrimaryKey; } }
        #endregion
    }
}