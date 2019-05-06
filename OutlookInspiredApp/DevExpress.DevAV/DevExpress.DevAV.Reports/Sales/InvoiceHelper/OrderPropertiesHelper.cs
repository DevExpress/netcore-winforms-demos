using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Range = DevExpress.Spreadsheet.Range;

namespace DevExpress.DevAV.Reports.Spreadsheet {
    public static class OrderPropertiesHelper {
        public static Dictionary<string, Action<Order, CellValue, OrderCollections>> Setters { get { return propertySetters; } }
        static Dictionary<string, Action<Order, CellValue, OrderCollections>> propertySetters = CreatePropertySetters();

        static Dictionary<string, Action<Order, CellValue, OrderCollections>> CreatePropertySetters() {
            var result = new Dictionary<string, Action<Order, CellValue, OrderCollections>>();
            result.Add(CellsHelper.FindLeftCell(CellsKind.Date), (order, value, source) => order.OrderDate = value.DateTimeValue);
            result.Add(CellsHelper.FindLeftCell(CellsKind.InvoiceNumber), (order, value, source) => SetIfNumericValue(value, s => order.InvoiceNumber = s));
            result.Add(CellsHelper.FindLeftCell(CellsKind.PONumber), (order, value, source) => SetIfNumericValue(value, s => order.PONumber = s));
            result.Add(CellsHelper.FindLeftCell(CellsKind.ShipDate), (order, value, source) => order.ShipDate = value.DateTimeValue);
            result.Add(CellsHelper.FindLeftCell(CellsKind.ShipVia), (order, value, source) => { order.ShipmentCourier = (ShipmentCourier)Enum.Parse(typeof(ShipmentCourier), value.TextValue); });
            result.Add(CellsHelper.FindLeftCell(CellsKind.Terms), (order, value, source) => SetIfNumericValue(value, s => order.OrderTerms = string.Format("{0} Days", s)));
            result.Add(CellsHelper.FindLeftCell(CellsKind.CustomerName), (order, value, source) => UpdateCustomerIfNeeded(order, value, source));
            result.Add(CellsHelper.FindLeftCell(CellsKind.CustomerStoreName), (order, value, source) => UpdateCustomerStoreIfNeeded(order, value, source));
            result.Add(CellsHelper.FindLeftCell(CellsKind.EmployeeName), (order, value, source) => UpdateEmployeeIfNeeded(order, value, source));
            result.Add(CellsHelper.FindLeftCell(CellsKind.Comments), (order, value, source) => order.Comments = value.TextValue);
            result.Add(CellsHelper.FindLeftCell(CellsKind.Shipping), (order, value, source) => order.ShippingAmount = (decimal)value.NumericValue);
            return result;
        }
        public static void UpdateCustomerIfNeeded(Order order, CellValue value, OrderCollections source) {
            var newCustomer = source.Customers.First(x => x.Name == value.TextValue);
            if(order.StoreId != newCustomer.Id) {
                order.Customer = newCustomer;
                order.CustomerId = newCustomer.Id;
            }
        }
        public static void UpdateCustomerStoreIfNeeded(Order order, CellValue value, OrderCollections source) {
            var newStore = source.CustomerStores.First(x => x.City == value.TextValue);
            if(order.StoreId != newStore.Id) {
                order.Store = newStore;
                order.StoreId = newStore.Id;
            }
        }
        public static void UpdateEmployeeIfNeeded(Order order, CellValue value, OrderCollections source) {
            var newEmployee = source.Employees.First(x => x.FullName == value.TextValue);
            if(order.EmployeeId != newEmployee.Id) {
                order.Employee = newEmployee;
                order.EmployeeId = newEmployee.Id;
            }
        }
        public static void InitializeOrderItem(Range itemRange, OrderItem orderItem) {
            itemRange[CellsHelper.GetOffset(CellsKind.ProductDescription)].Value = orderItem.Product != null
                ? orderItem.Product.Name : string.Empty;
            itemRange[CellsHelper.GetOffset(CellsKind.Quantity)].Value = orderItem.ProductUnits > 0 ? orderItem.ProductUnits : 1;
            itemRange[CellsHelper.GetOffset(CellsKind.UnitPrice)].Value = (double)orderItem.ProductPrice;
            itemRange[CellsHelper.GetOffset(CellsKind.Discount)].Value = (double)orderItem.Discount;
        }
        public static void UpdateProduct(OrderItem orderItem, CellValue productCell, OrderCollections source) {
            var newProduct = source.Products.First(x => x.Name == productCell.TextValue);
            orderItem.Product = newProduct;
            orderItem.ProductId = newProduct.Id;
        }
        public static void UpdateProductUnits(OrderItem orderItem, Range orderItemRange, Worksheet invoice) {
            orderItem.ProductUnits = (int)CellsHelper.GetOrderItemCellValue(CellsKind.Quantity, orderItemRange, invoice).NumericValue;
        }
        public static void UpdateProductPrice(Cell cell, OrderItem orderItem, Range orderItemRange) {
            if(CellsHelper.IsOrderItemProductCell(cell, orderItemRange)) {
                orderItemRange[CellsHelper.GetOffset(CellsKind.UnitPrice)].Value = (double)orderItem.Product.SalePrice;
                orderItem.ProductPrice = orderItem.Product.SalePrice;
            }
        }
        static void SetIfNumericValue(CellValue value, Action<string> setValue) {
            if(value.IsNumeric)
                setValue.Invoke(value.NumericValue.ToString("F0"));
        }
    }
}
