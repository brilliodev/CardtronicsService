using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocatorSearchApi.Model
{
    public class NetworkRevenues
    {
        public int id { get; set; }
        public int networkID { get; set; }

        public int revenue { get; set; }

        public DateTime revenueOn { get; set; }

    }
}