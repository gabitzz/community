namespace DevExpress.DevAV
{
    using DevExpress.Common;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public abstract class DatabaseObject : IDataErrorInfo
    {
        protected DatabaseObject()
        {
        }

        [Key]
        public long Id { get; set; }

        string IDataErrorInfo.Error
        {
            get
            {
                return null;
            }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                return IDataErrorInfoHelper.GetErrorText(this, columnName);
            }
        }
    }
}

