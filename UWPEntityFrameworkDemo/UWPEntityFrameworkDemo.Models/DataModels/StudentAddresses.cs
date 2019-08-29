using System;
using System.Collections.Generic;
using System.Text;

namespace UWPEntityFrameworkDemo.Models.DataModels
{
    public partial class StudentAddress : BaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string AreaCode { get; set; }

        #region Relationship Attributes
        public Student Student { get; set; }
        #endregion
    }
}
