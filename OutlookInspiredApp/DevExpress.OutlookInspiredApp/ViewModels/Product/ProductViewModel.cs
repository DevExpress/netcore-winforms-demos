using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products, x => x.Name) {
        }

        /// <summary>
		/// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((ProductViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }

        /// <summary>
		/// The view model that contains a look-up collection of Pictures for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Picture> LookUpPictures {
            get { return GetLookUpEntitiesViewModel((ProductViewModel x) => x.LookUpPictures, x => x.Pictures); }
        }

        /// <summary>
        /// The view model for the ProductCatalog detail collection.
        /// </summary>
        public CollectionViewModelBase<ProductCatalog, ProductCatalog, long, IDevAVDbUnitOfWork> ProductCatalogDetails {
            get {
                return GetDetailsCollectionViewModel<ProductViewModel, ProductCatalog, long, long?>(
                    propertyExpression: (ProductViewModel x) => x.ProductCatalogDetails,
                    getRepositoryFunc: x => x.ProductCatalogs,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Product);
            }
        }

        /// <summary>
        /// The view model for the ProductOrderItems detail collection.
        /// </summary>
        public CollectionViewModelBase<OrderItem, OrderItem, long, IDevAVDbUnitOfWork> ProductOrderItemsDetails {
            get {
                return GetDetailsCollectionViewModel<ProductViewModel, OrderItem, long, long?>(
                    propertyExpression: (ProductViewModel x) => x.ProductOrderItemsDetails,
                    getRepositoryFunc: x => x.OrderItems,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Product);
            }
        }

        /// <summary>
        /// The view model for the ProductImages detail collection.
        /// </summary>
        public CollectionViewModelBase<ProductImage, ProductImage, long, IDevAVDbUnitOfWork> ProductImagesDetails {
            get {
                return GetDetailsCollectionViewModel<ProductViewModel, ProductImage, long, long?>(
                    propertyExpression: (ProductViewModel x) => x.ProductImagesDetails,
                    getRepositoryFunc: x => x.ProductImages,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Product);
            }
        }
    }
}
