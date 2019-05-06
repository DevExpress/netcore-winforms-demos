using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevExpress.Common;
using DevExpress.DataAnnotations;

namespace DevExpress.DevAV {
    public partial class Address : ObservableObject, IDataErrorInfo {
        string line;
        [Display(Name = "Address")]
        public string Line {
            get { return line; }
            set { SetPropertyValue(ref line, value); }
        }
        string city;
        public string City {
            get { return city; }
            set { SetPropertyValue(ref city, value); }
        }
        StateEnum state;
        public StateEnum State {
            get { return state; }
            set { SetPropertyValue(ref state, value); }
        }
        string zipCode;
        [ZipCode, Display(Name = "Zip code")]
        public string ZipCode {
            get { return zipCode; }
            set { SetPropertyValue(ref zipCode, value); }
        }

        double latitude;
        public double Latitude {
            get { return latitude; }
            set { SetPropertyValue(ref latitude, value); }
        }
        double longitude;
        public double Longitude {
            get { return longitude; }
            set { SetPropertyValue(ref longitude, value); }
        }
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

    public static partial class AddressHelper {
        public static void UpdateAddress(Address address, string line, string city, StateEnum state, string zipCode, double latitude, double longtitude) {
            address.Line = line;
            address.City = city;
            address.State = state;
            address.ZipCode = zipCode;
            address.Latitude = latitude;
            address.Longitude = longtitude;
        }
    }
}
