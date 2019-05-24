using LocatorSearchApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocatorSearchApi.Data
{
    public class LocatorSearchDatas
    {
        public  List<Networks> networks = new List<Networks>() {
            new Networks {networkID=1101,   NetworkName="Get Go Dallas", status="Live",  intuit="",   isClientNetwork=true,
                logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

            new Networks {networkID=1103,   NetworkName="Tesco Frisco", status="Live",  intuit="",   isClientNetwork=true,
                logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

            new Networks {networkID=1104,   NetworkName="Kinemart TX", status="Live",  intuit="",   isClientNetwork=true,
                logo ="",productList=new List<Products>(){ Products.DIWeb,Products.DIApi},websiteURL=""  },

            new Networks {networkID=1112,   NetworkName="Walmart TX", status="Closed",  intuit="",   isClientNetwork=true,
                logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

            new Networks {networkID=1113,   NetworkName="Homedepot", status="Not Live",  intuit="",   isClientNetwork=true,
                logo ="",productList=new List<Products>(){ Products.Others},websiteURL=""  },

        };


        public List<NetworkRevenues> networkRevenues = new List<NetworkRevenues>()
        {
            new NetworkRevenues { id=1, networkID=1101, revenue=120,    revenueOn=new DateTime(2019,01,23) },
            new NetworkRevenues { id=2, networkID=1101, revenue=140,    revenueOn=new DateTime(2019,02,23) },
            new NetworkRevenues { id=3, networkID=1103, revenue=90,    revenueOn=new DateTime(2019,02,21) },
            new NetworkRevenues { id=4, networkID=1103, revenue=20,    revenueOn=new DateTime(2018,12,23) },
            new NetworkRevenues { id=5, networkID=1103, revenue=50,    revenueOn=new DateTime(2019,03,23) },
            new NetworkRevenues { id=6, networkID=1103, revenue=250,    revenueOn=new DateTime(2019,03,13) },
        };



      


    }
}