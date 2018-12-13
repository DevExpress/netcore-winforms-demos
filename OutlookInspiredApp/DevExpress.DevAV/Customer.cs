using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DevExpress.DevAV {
    public enum CustomerStatus {
        Active,
        Suspended
    }
    public partial class Customer : DatabaseObject {
        public Customer() {
            Employees = new List<CustomerEmployee>();
            Orders = new List<Order>();
            _homeOffice = new Address();
            _billingAddress = new Address();
        }
        [Required]
        public string Name { get; set; }
        Address _homeOffice;
        [NotMapped]
        public Address HomeOffice {
            get {
                AddressHelper.UpdateAddress(_homeOffice, HomeOffice_Line, HomeOffice_City, HomeOffice_State, HomeOffice_ZipCode, HomeOffice_Latitude, HomeOffice_Longitude);
                return _homeOffice;
            }
            set {
                AddressHelper.UpdateAddress(_homeOffice, value.Line, value.City, value.State, value.ZipCode, value.Latitude, value.Longitude);
                HomeOffice_Line = _homeOffice.Line;
                HomeOffice_City = _homeOffice.City;
                HomeOffice_State = _homeOffice.State;
                HomeOffice_ZipCode = _homeOffice.ZipCode;
                HomeOffice_Latitude = _homeOffice.Latitude;
                HomeOffice_Longitude = _homeOffice.Longitude;
            }
        }
        Address _billingAddress;
        [NotMapped]
        public Address BillingAddress {
            get {
                AddressHelper.UpdateAddress(_billingAddress, BillingAddress_Line, BillingAddress_City, BillingAddress_State, BillingAddress_ZipCode, BillingAddress_Latitude, BillingAddress_Longitude);
                return _billingAddress;
            }
            set {
                AddressHelper.UpdateAddress(_billingAddress, value.Line, value.City, value.State, value.ZipCode, value.Latitude, value.Longitude);
                BillingAddress_Line = _billingAddress.Line;
                BillingAddress_City = _billingAddress.City;
                BillingAddress_State = _billingAddress.State;
                BillingAddress_ZipCode = _billingAddress.ZipCode;
                BillingAddress_Latitude = _billingAddress.Latitude;
                BillingAddress_Longitude = _billingAddress.Longitude;
            }
        }
        #region EFCore
        public string HomeOffice_Line { get; set; }
        public string HomeOffice_City { get; set; }
        public StateEnum HomeOffice_State { get; set; }
        public string HomeOffice_ZipCode { get; set; }
        public double HomeOffice_Latitude { get; set; }
        public double HomeOffice_Longitude { get; set; }
        public string BillingAddress_Line { get; set; }
        public string BillingAddress_City { get; set; }
        public StateEnum BillingAddress_State { get; set; }
        public string BillingAddress_ZipCode { get; set; }
        public double BillingAddress_Latitude { get; set; }
        public double BillingAddress_Longitude { get; set; }
        #endregion

        public virtual List<CustomerEmployee> Employees { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Phone]
        public string Fax { get; set; }
        [Url]
        public string Website { get; set; }
        [DataType(DataType.Currency)]
        public decimal AnnualRevenue { get; set; }
        [Display(Name = "Total Stores")]
        public int TotalStores { get; set; }
        [Display(Name = "Total Employees")]
        public int TotalEmployees { get; set; }
        public CustomerStatus Status { get; set; }
        [InverseProperty("Customer")]
        public virtual List<Order> Orders { get; set; }
        [InverseProperty("Customer")]
        public virtual List<Quote> Quotes { get; set; }
        [InverseProperty("Customer")]
        public virtual List<CustomerStore> CustomerStores { get; set; }
        public virtual string Profile { get; set; }
        public byte[] Logo { get; set; }
        Image img = null;
        public Image Image {
            get {
                if(img == null)
                    img = CreateImage(Logo);
                return img;
            }
        }
        internal static Image CreateImage(byte[] data) {
            if (data == null)
                return null;// ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.DevAV.Resources.Unknown-user.png", typeof(Employee).Assembly);
            else
                return DevAVByteImageConverter.FromByteArray(data);
        }
    }
}