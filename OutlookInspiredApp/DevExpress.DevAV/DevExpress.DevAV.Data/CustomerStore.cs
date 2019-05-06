using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace DevExpress.DevAV {
    public class CustomerStore : DatabaseObject {
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }
#if DXCORE3
        public CustomerStore() {
            _address = new Address();
            _address.PropertyChanged += (s, e) => SetPropertyValue(e.PropertyName, "Address_", (Address)s);
        }
        Address _address;
        [NotMapped]
        public Address Address {
            get {
                AddressHelper.UpdateAddress(_address, Address_Line, Address_City, Address_State, Address_ZipCode, Address_Latitude, Address_Longitude);
                return _address;
            }
            set { AddressHelper.UpdateAddress(_address, value.Line, value.City, value.State, value.ZipCode, value.Latitude, value.Longitude); }
        }
#else
        public Address Address { get; set; }
#endif
#if ONGENERATEDATABASE || DXCORE3
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Address_Line { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Address_City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public StateEnum Address_State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Address_ZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double Address_Latitude { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double Address_Longitude { get; set; }
#endif
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int TotalEmployees { get; set; }
        public int SquereFootage { get; set; }
        [DataType(DataType.Currency)]
        public decimal AnnualSales { get; set; }
        public virtual Crest Crest { get; set; }
        public long? CrestId { get; set; }
        public string Location { get; set; }
        public string City { get { return Address == null ? "" : Address.City; } }
        public StateEnum State { get { return Address == null ? StateEnum.CA : Address.State; } }
        public virtual ICollection<CustomerEmployee> CustomerEmployees { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public string CustomerName {
            get { return (Customer != null) ? Customer.Name : null; }
        }
        public string AddressLine {
            get { return (Address != null) ? Address.ToString() : null; }
        }
        public string AddressLines {
            get { return (Address != null) ? string.Format("{0}\r\n{1} {2}", Address.Line, Address.State, Address.ZipCode) : null; }
        }
        public string CrestCity {
            get { return (Crest != null) ? Crest.CityName : null; }
        }
        Image smallImg;
        public Image CrestSmallImage {
            get {
                if(smallImg == null && Crest != null)
                    smallImg = CreateImage(Crest.SmallImage);
                return smallImg;
            }
        }
        Image largeImg;
        public Image CrestLargeImage {
            get {
                if(largeImg == null && Crest != null)
                    largeImg = CreateImage(Crest.LargeImage);
                return largeImg;
            }
        }
        Image CreateImage(byte[] data) {
            if(data == null)
                return ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.DevAV.Resources.Unknown-user.png", typeof(Employee).Assembly);
            else
                return ByteImageConverter.FromByteArray(data);
        }
    }
}