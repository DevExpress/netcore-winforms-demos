namespace DevExpress.DevAV.Services {

    public interface IModuleTypesResolver {
        string GetName(ModuleType moduleType);
        string GetTypeName(ModuleType moduleType);
        System.Guid GetId(ModuleType moduleType);
        ModuleType GetMainModuleType(ModuleType type);
        ModuleType GetMapModuleType(ModuleType type);
        ModuleType GetMailMergeModuleType(ModuleType type);
        ModuleType GetAnalysisModuleType(ModuleType type);
        ModuleType GetPeekModuleType(ModuleType type);
        ModuleType GetNavPaneModuleType(ModuleType type);
        ModuleType GetNavPaneHeaderModuleType(ModuleType type);
        ModuleType GetExportModuleType(ModuleType type);
        ModuleType GetPrintModuleType(ModuleType type);
    }
    class ModuleTypesResolver : IModuleTypesResolver {
        public string GetName(ModuleType moduleType) {
            if(moduleType == ModuleType.Unknown)
                return null;
            return moduleType.ToString();
        }
        public string GetTypeName(ModuleType moduleType) {
            if(moduleType == ModuleType.Unknown)
                return null;
            return moduleType.ToString();
        }
        public System.Guid GetId(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return new System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a2");
                case ModuleType.Customers:
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return new System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a3");
                case ModuleType.Products:
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return new System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a4");
                case ModuleType.Orders:
                case ModuleType.OrdersPeek:
                case ModuleType.OrdersFilterPane:
                    return new System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a5");
                case ModuleType.Quotes:
                case ModuleType.QuotesPeek:
                case ModuleType.QuotesFilterPane:
                    return new System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a6");
                default:
                    return System.Guid.Empty;
            }
        }
        public ModuleType GetMainModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return ModuleType.Employees;
                case ModuleType.Customers:
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return ModuleType.Customers;
                case ModuleType.Products:
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return ModuleType.Products;
                case ModuleType.Orders:
                case ModuleType.OrdersPeek:
                case ModuleType.OrdersFilterPane:
                    return ModuleType.Orders;
                case ModuleType.Quotes:
                case ModuleType.QuotesPeek:
                case ModuleType.QuotesFilterPane:
                    return ModuleType.Quotes;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetMapModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeeEditView:
                    return ModuleType.EmployeeMapView;
                case ModuleType.Customers:
                case ModuleType.CustomerEditView:
                    return ModuleType.CustomerMapView;
                case ModuleType.Products:
                case ModuleType.ProductEditView:
                    return ModuleType.ProductMapView;
                case ModuleType.Orders:
                case ModuleType.OrderEditView:
                    return ModuleType.OrderMapView;
                case ModuleType.Quotes:
                case ModuleType.QuoteEditView:
                    return ModuleType.QuoteMapView;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetMailMergeModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeeEditView:
                    return ModuleType.EmployeeMailMerge;
                case ModuleType.Orders:
                case ModuleType.OrderEditView:
                    return ModuleType.OrderMailMerge;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetAnalysisModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Customers:
                case ModuleType.CustomerEditView:
                    return ModuleType.CustomerAnalysis;
                case ModuleType.Products:
                case ModuleType.ProductEditView:
                    return ModuleType.ProductAnalysis;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetPeekModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return ModuleType.EmployeesPeek;
                case ModuleType.Customers:
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return ModuleType.CustomersPeek;
                case ModuleType.Products:
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return ModuleType.ProductsPeek;
                case ModuleType.Orders:
                case ModuleType.OrdersPeek:
                case ModuleType.OrdersFilterPane:
                    return ModuleType.OrdersPeek;
                case ModuleType.Quotes:
                case ModuleType.QuotesPeek:
                case ModuleType.QuotesFilterPane:
                    return ModuleType.QuotesPeek;

                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetNavPaneModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return ModuleType.EmployeesFilterPane;
                case ModuleType.Customers:
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return ModuleType.CustomersFilterPane;
                case ModuleType.Products:
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return ModuleType.ProductsFilterPane;
                case ModuleType.Orders:
                case ModuleType.OrdersPeek:
                case ModuleType.OrdersFilterPane:
                    return ModuleType.OrdersFilterPane;
                case ModuleType.Quotes:
                case ModuleType.QuotesPeek:
                case ModuleType.QuotesFilterPane:
                    return ModuleType.QuotesFilterPane;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetNavPaneHeaderModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesFilterPane:
                    return ModuleType.EmployeesFilterPaneCollapsed;
                case ModuleType.Customers:
                case ModuleType.CustomersFilterPane:
                    return ModuleType.CustomersFilterPaneCollapsed;
                case ModuleType.Products:
                case ModuleType.ProductsFilterPane:
                    return ModuleType.ProductsFilterPaneCollapsed;
                case ModuleType.Orders:
                case ModuleType.OrdersFilterPane:
                    return ModuleType.OrdersFilterPaneCollapsed;
                case ModuleType.Quotes:
                case ModuleType.QuotesFilterPane:
                    return ModuleType.QuotesFilterPaneCollapsed;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetExportModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                    return ModuleType.EmployeesExport;
                case ModuleType.Customers:
                    return ModuleType.CustomersExport;
                case ModuleType.Products:
                    return ModuleType.ProductsExport;
                case ModuleType.Orders:
                    return ModuleType.OrdersExport;
                case ModuleType.Quotes:
                    return ModuleType.QuotesExport;
                default:
                    return ModuleType.Unknown;
            }
        }
        public ModuleType GetPrintModuleType(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Employees:
                    return ModuleType.EmployeesPrint;
                case ModuleType.Customers:
                    return ModuleType.CustomersPrint;
                case ModuleType.Products:
                    return ModuleType.ProductsPrint;
                case ModuleType.Orders:
                    return ModuleType.OrdersPrint;
                case ModuleType.Quotes:
                    return ModuleType.QuotesPrint;
                default:
                    return ModuleType.Unknown;
            }
        }
    }
}