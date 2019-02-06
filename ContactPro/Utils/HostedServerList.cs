using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactPro.Utils
{
    public class HostedServerList
    {
        public static IEnumerable<SelectListItem> GetHostedServerList()
        {
            IList<SelectListItem> HostedServers = new List<SelectListItem>
            {
                new SelectListItem() {Text="Primary", Value="Primary"},
                new SelectListItem() { Text="Web1", Value="Web1"},
                new SelectListItem() { Text="Web3", Value="Web2"},
                new SelectListItem() { Text="Web3", Value="Web3"},
                new SelectListItem() { Text="Web4", Value="Web4"},
                new SelectListItem() { Text="Web5", Value="Web5"}
            };
            return HostedServers;
        }
    }
}