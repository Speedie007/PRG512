using System;
using System.Collections.Generic;
using System.Text;

namespace UWPEntityFrameworkDemo.Models.DataModels
{
    public class Student : BaseEntity
    {
        public Student()
        {
            StudentAddresses = new List<StudentAddress>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        #region RElationShip Attributes
                public ICollection<StudentAddress> StudentAddresses { get; set; }
        #endregion
    }
}
