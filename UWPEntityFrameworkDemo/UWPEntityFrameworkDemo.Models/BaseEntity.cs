using System;
using System.Collections.Generic;
using System.Text;

namespace UWPEntityFrameworkDemo.Models
{
    public abstract class BaseEntity: IBaseEntity
    {
        public int Id { get; set; }
    }
}
