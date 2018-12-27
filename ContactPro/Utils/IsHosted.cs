using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactPro.Utils
{
    public class IsHosted
    {
        public static IEnumerable<SelectListItem> GetIsHosted()
        {
            IList<SelectListItem> _ishosted = new List<SelectListItem>
            {
                new SelectListItem() {Text="Yes", Value="Y"},
                new SelectListItem() { Text="No", Value="N"},
            };
            return _ishosted;
        }
    }
}