using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactPro.Utils
{
    public class CountryList
    {
        public static IEnumerable<SelectListItem> GetCountryList()
        {
            IList<SelectListItem> countries = new List<SelectListItem>
            {
                new SelectListItem() {Text="United States of America", Value="USA"},
                new SelectListItem() { Text="Canada", Value="CAN"},
                new SelectListItem() { Text="Jamaica", Value="JAM"},
            };
            return countries;
        }
    }
}