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

                var expectedJsonData = "{\"networkStatus\":[{\"key\":\"Live\",\"value\":6},{\"key\":\"Closed\",\"value\":1},{\"key\":\"Not Live\",\"value\":2}],\"clientNetworkStatus\":[{\"key\":\"Live\",\"value\":4},{\"key\":\"Closed\",\"value\":1},{\"key\":\"Not Live\",\"value\":1}],\"nonClientNetworkStatus\":[{\"key\":\"Live\",\"value\":2},{\"key\":\"Not Live\",\"value\":1}]}";

                List<Networks> items = new List<Networks>
                                {
                         new Networks {networkID=1101,   NetworkName="Get Go Dallas", status="Live",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

                         new Networks {networkID=1103,   NetworkName="Tesco Frisco", status="Live",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

                         new Networks {networkID=1104,   NetworkName="Kinemart TX", status="Live",  intuit="",   isClientNetwork=false,
                            logo ="",productList=new List<Products>(){ Products.DIWeb,Products.DIApi},websiteURL=""  },

                         new Networks {networkID=1112,   NetworkName="Walmart TX", status="Closed",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.LSApi,Products.LSWeb},websiteURL=""  },

                         new Networks {networkID=1113,   NetworkName="Homedepot", status="Not Live",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.Others},websiteURL=""  },

                         new Networks {networkID=1114,   NetworkName="Chase TX", status="Not Live",  intuit="",   isClientNetwork=false,
                            logo ="",productList=new List<Products>(){ Products.DIApi},websiteURL=""  },

                         new Networks {networkID=1115,   NetworkName="Bank Of America", status="Live",  intuit="",   isClientNetwork=false,
                            logo ="",productList=new List<Products>(){ Products.LSWeb},websiteURL=""  },

                         new Networks {networkID=1116,   NetworkName="All point Walgreens", status="Live",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.LSWeb, Products.LSApi},websiteURL=""  },

                         new Networks {networkID=1116,   NetworkName="CVS", status="Live",  intuit="",   isClientNetwork=true,
                            logo ="",productList=new List<Products>(){ Products.Others},websiteURL=""  },
                                };


                    

                        var result = status.GetNetworkStatusGraph(items);
                        //JsonConvert.SerializeObject(result);
                        var json = JsonConvert.SerializeObject(result);

                        Assert.AreEqual(expectedJsonData, json);
                    }




        [TestMethod()]
        public void GetNetworkRevenue()
        {
            NetworkRevenueContract revenueStatus = new NetworkRevenueContract();
            var expectedRevenueOutput = "{\"monthly\":[{\"key\":\"12019\",\"value\":120},{\"key\":\"22019\",\"value\":230},{\"key\":\"122018\",\"value\":20},{\"key\":\"32019\",\"value\":300}],\"yearly\":[{\"key\":\"2019\",\"value\":650},{\"key\":\"2018\",\"value\":20}],\"quarterly\":[{\"key\":\"02019\",\"value\":650},{\"key\":\"32018\",\"value\":20}]}";
            List<NetworkRevenues> revenueItems = new List<NetworkRevenues>()
            {
            new NetworkRevenues { id = 1, networkID = 1101, revenue = 120, revenueOn = new DateTime(2019, 01, 23) },
            new NetworkRevenues { id = 2, networkID = 1101, revenue = 140, revenueOn = new DateTime(2019, 02, 23) },
            new NetworkRevenues { id = 3, networkID = 1103, revenue = 90, revenueOn = new DateTime(2019, 02, 21) },
            new NetworkRevenues { id = 4, networkID = 1103, revenue = 20, revenueOn = new DateTime(2018, 12, 23) },
            new NetworkRevenues { id = 5, networkID = 1103, revenue = 50, revenueOn = new DateTime(2019, 03, 23) },
            new NetworkRevenues { id = 6, networkID = 1103, revenue = 250, revenueOn = new DateTime(2019, 03, 13) }, };
            var actualResult = revenueStatus.GetNetworkRevenue(revenueItems);
            var actualResultJson = JsonConvert.SerializeObject(actualResult);

            Assert.AreEqual(expectedRevenueOutput, actualResultJson);
        }
        
     }
} 