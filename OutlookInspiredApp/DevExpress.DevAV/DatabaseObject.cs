using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using DevExpress.Common;

namespace DevExpress.DevAV {
    public abstract class DatabaseObject : IDataErrorInfo {
        [Key]
        public long Id { get; set; }
        #region IDataErrorInfo
        string IDataErrorInfo.Error { get { return null; } }
        string IDataErrorInfo.this[string columnName] {
            get { return IDataErrorInfoHelper.GetErrorText(this, columnName); }
        }
        #endregion
    }
}
