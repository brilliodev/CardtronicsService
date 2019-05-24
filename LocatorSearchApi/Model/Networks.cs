using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocatorSearchApi.Model
{
    public class Networks
    {
        public int networkID { get; set; }
        public string NetworkName { get; set; }

        public string status { get; set; }

        public string intuit { get; set; }

        public string logo { get; set; }
        public string websiteURL { get; set; }

        public Boolean isClientNetwork { get; set; }

        public List<Products> productList { get; set; }


    }
}