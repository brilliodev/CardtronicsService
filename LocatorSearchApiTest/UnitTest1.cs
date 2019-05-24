using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocatorSearchApi.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocatorSearchApi.Model;
using Newtonsoft.Json;

namespace LocatorSearchApi.DataContracts.Tests
{



    [TestClass()]
    public class NetworksStatusContractTests

    {


        [TestMethod()]

        public void GetNetworkStatusGraphTest()
        {
            NetworksStatusContract status = new NetworksStatusContract();

            var expectedJsonData = "{\"networkStatus\":[{\"key\":\"Live\",\"value\":3},{\"key\":\"Closed\",\"value\":1},{\"key\":\"Not Live\",\"value\":1}]}";


            List<Networks> items = new List<Networks>
                    {
                        new Networks { NetworkName ="Get Go Dallas",intuit ="" ,isClientNetwork =true,logo ="",networkID =1101,status="Live",productList =new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL="" },
                        new Networks { NetworkName ="Tesco Frisco",intuit ="" ,isClientNetwork =true,logo ="",networkID =1103,status="Live", productList =new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL="" },

                        new Networks {networkID=1104,   NetworkName="Kinemart TX", status="Live",  intuit="",   isClientNetwork=true,
                        logo ="",productList=new List<Products>(){ Products.DIWeb,Products.DIApi},websiteURL=""  },

                        new Networks {networkID=1112,   NetworkName="Walmart TX", status="Closed",  intuit="",   isClientNetwork=true,
                        logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

                       new Networks {networkID=1113,   NetworkName="Homedepot", status="Not Live",  intuit="",   isClientNetwork=true,
                       logo ="",productList=new List<Products>(){ Products.Others},websiteURL=""  },
                    };

            var result = status.GetNetworkStatusGraph(items);
            //JsonConvert.SerializeObject(result);
            var json = JsonConvert.SerializeObject(result);

            Assert.AreEqual(expectedJsonData, json);
        }





    }
}