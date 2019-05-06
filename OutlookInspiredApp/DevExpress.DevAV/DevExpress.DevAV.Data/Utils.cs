using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.DevAV {
    public static partial class AddressHelper {
        public static Address DevAVHomeOffice { get { return devAVHomeOffice; } }

        static Address devAVHomeOffice = new Address {
            City = "Glendale",
            Line = "505 N. Brand Blvd",
            State = StateEnum.CA,
            ZipCode = "91203",
            Latitude = 34.1532866,
            Longitude = -118.2555815
        };
    }
}
