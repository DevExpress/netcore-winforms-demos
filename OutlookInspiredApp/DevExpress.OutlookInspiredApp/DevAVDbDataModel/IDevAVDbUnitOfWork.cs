using System;
using System.Linq;
using DevExpress.Mvvm.DataModel;

namespace DevExpress.DevAV.DevAVDbDataModel {
    /// <summary>
    /// IDevAVDbUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IDevAVDbUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The CustomerCommunication entities repository.
        /// </summary>
		IRepository<CustomerCommunication, long> Communications { get; }
        
        /// <summary>
        /// The CustomerEmployee entities repository.
        /// </summary>
		IRepository<CustomerEmployee, long> CustomerEmployees { get; }
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, long> Customers { get; }
        
        /// <summary>
        /// The CustomerStore entities repository.
        /// </summary>
		IRepository<CustomerStore, long> CustomerStores { get; }
        
        /// <summary>
        /// The Crest entities repository.
        /// </summary>
		IRepository<Crest, long> Crests { get; }
        
        /// <summary>
        /// The Order entities repository.
        /// </summary>
		IRepository<Order, long> Orders { get; }
        
        /// <summary>
        /// The Employee entities repository.
        /// </summary>
		IRepository<Employee, long> Employees { get; }
        
        /// <summary>
        /// The EmployeeTask entities repository.
        /// </summary>
		IRepository<EmployeeTask, long> Tasks { get; }
        
        /// <summary>
        /// The Evaluation entities repository.
        /// </summary>
		IRepository<Evaluation, long> Evaluations { get; }
        
        /// <summary>
        /// The Picture entities repository.
        /// </summary>
		IRepository<Picture, long> Pictures { get; }
        
        /// <summary>
        /// The Probation entities repository.
        /// </summary>
		IRepository<Probation, long> Probations { get; }
        
        /// <summary>
        /// The OrderItem entities repository.
        /// </summary>
		IRepository<OrderItem, long> OrderItems { get; }
        
        /// <summary>
        /// The Product entities repository.
        /// </summary>
		IRepository<Product, long> Products { get; }
        
        /// <summary>
        /// The ProductCatalog entities repository.
        /// </summary>
		IRepository<ProductCatalog, long> ProductCatalogs { get; }
        
        /// <summary>
        /// The ProductImage entities repository.
        /// </summary>
		IRepository<ProductImage, long> ProductImages { get; }
        
        /// <summary>
        /// The Quote entities repository.
        /// </summary>
		IRepository<Quote, long> Quotes { get; }
        
        /// <summary>
        /// The QuoteItem entities repository.
        /// </summary>
		IRepository<QuoteItem, long> QuoteItems { get; }
        
        /// <summary>
        /// The State entities repository.
        /// </summary>
		IRepository<State, StateEnum> States { get; }
        
        /// <summary>
        /// The DatabaseVersion entities repository.
        /// </summary>
		IRepository<DatabaseVersion, long> Version { get; }
    }
}
