using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Runtime.Serialization;
using DevExpress.DataAnnotations;
using System.Collections.Generic;

namespace DevExpress.DevAV {
    public class CustomerEmployee : DatabaseObject {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public PersonPrefix Prefix { get; set; }
        [Required, Phone, Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public virtual Picture Picture { get; set; }
        public long? PictureId { get; set; }
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }
        public virtual CustomerStore CustomerStore { get; set; }
        public long? CustomerStoreId { get; set; }
        public string Position { get; set; }
        public bool IsPurchaseAuthority { get; set; }
        public virtual ICollection<CustomerCommunication> CustomerCommunications { get; set; }
        public Address Address {
            get { return (CustomerStore != null) ? CustomerStore.Address : null; }
            set { }
        }
        public virtual ICollection<EmployeeTask> EmployeeTasks { get; set; }
        Image _photo = null;
        [NotMapped]
        public Image Photo {
            get {
                if(_photo == null)
                    _photo = Picture.CreateImage();
                return _photo;
            }
            set {
                _photo = value;
                Picture = PictureExtension.FromImage(value);
            }
        }
        public override string ToString() {
            return FullName;
        }
    }
}