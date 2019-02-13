using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactPro.Models
{
    public class BaseEntity
    {
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}