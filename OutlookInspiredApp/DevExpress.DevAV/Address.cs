using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Common;
using DevExpress.DataAnnotations;

namespace DevExpress.DevAV {
    [NotMapped]
    public partial class Address : IDataErrorInfo {
        [Display(Name = "Address")]
        public string Line { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        [ZipCode, Display(Name = "Zip code")]
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string CityLine {
            get { return GetCityLine(City, State, ZipCode); }
        }
        public override string ToString() {
            return string.Format("{0}, {1}", Line, CityLine);
        }
        #region IDataErrorInfo
        string IDataErrorInfo.Error { get { return null; } }
        string IDataErrorInfo.this[string columnName] {
            get { return IDataErrorInfoHelper.GetErrorText(this, columnName); }
        }
        #endregion

        internal static string GetCityLine(string city, StateEnum state, string zipCode) {
            return string.Format("{0}, {1} {2}", city, state, zipCode);
        }
    }
    public static class AddressHelper {
        public static Address DevAVHomeOffice { get { return devAVHomeOffice; } }

        static Address devAVHomeOffice = new Address {
            City = "Glendale",
            Line = "505 N. Brand Blvd",
            State = StateEnum.CA,
            ZipCode = "91203",
            Latitude = 34.1532866,
            Longitude = -118.2555815
        };
        public static void UpdateAddress(Address address, string line, string city, StateEnum state, string zipCode, double latitude, double longtitude){
            address.Line = line;
            address.City = city;
            address.State = state;
            address.ZipCode = zipCode;
            address.Latitude = latitude;
            address.Longitude = longtitude;
        }
    }
}
