using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocatorSearchApi.Model
{
    public class NetworkSearch
    {
        public int id { get; set; }
        public int networkID { get; set; }
        public DateTime searchOn { get; set; }
    }
}