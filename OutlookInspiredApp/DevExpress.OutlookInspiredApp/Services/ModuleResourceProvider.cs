namespace DevExpress.DevAV.Services {
    public interface IModuleResourceProvider {
        string GetCaption(ModuleType moduleType);
        string GetModuleImageUri(ModuleType moduleType, bool smallImage = false);
    }
    //
    public class ModuleResourceProvider : IModuleResourceProvider {
        public string GetCaption(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Unknown:
                    return null;
                case ModuleType.EmployeesPeek:
                case ModuleType.EmployeesFilterPane:
                    return "Employees";
                case ModuleType.CustomersPeek:
                case ModuleType.CustomersFilterPane:
                    return "Customers";
                case ModuleType.ProductsPeek:
                case ModuleType.ProductsFilterPane:
                    return "Products";
                case ModuleType.Orders:
                case ModuleType.OrdersFilterPane:
                    return "Sales";
                case ModuleType.Quotes:
                case ModuleType.QuotesFilterPane:
                    return "Opportunities";
                default:
                    return moduleType.ToString();
            }
        }
        public virtual string GetModuleImageUri(ModuleType moduleType, bool smallImage = false) {
            switch(moduleType) {
                case ModuleType.Employees:
                case ModuleType.EmployeesFilterPane:
                    return smallImage ?
                        "resource://DevExpress.DevAV.Resources.Modules.Employees.svg?Size=16x16" :
                        "resource://DevExpress.DevAV.Resources.Modules.Employees.svg";
                case ModuleType.Customers:
                case ModuleType.CustomersFilterPane:
                    return smallImage ?
                        "resource://DevExpress.DevAV.Resources.Modules.Customers.svg?Size=16x16" :
                        "resource://DevExpress.DevAV.Resources.Modules.Customers.svg";
                case ModuleType.Products:
                case ModuleType.ProductsFilterPane:
                    return smallImage ?
                        "resource://DevExpress.DevAV.Resources.Modules.Products.svg?Size=16x16" :
                        "resource://DevExpress.DevAV.Resources.Modules.Products.svg";
                case ModuleType.Orders:
                case ModuleType.OrdersFilterPane:
                    return smallImage ?
                        "resource://DevExpress.DevAV.Resources.Modules.Sales.svg?Size=16x16" :
                        "resource://DevExpress.DevAV.Resources.Modules.Sales.svg";
                case ModuleType.Quotes:
                case ModuleType.QuotesFilterPane:
                    return smallImage ?
                        "resource://DevExpress.DevAV.Resources.Modules.Opportunities.svg?Size=16x16" :
                        "resource://DevExpress.DevAV.Resources.Modules.Opportunities.svg";
                case ModuleType.Unknown:
                    return null;
                default:
                    return null;
            }
        }
    }
}