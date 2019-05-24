using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocatorSearchApi.Data;
using LocatorSearchApi.DataContracts;
using LocatorSearchApi.Model;

namespace LocatorSearchApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LocatorSearchService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LocatorSearchService.svc or LocatorSearchService.svc.cs at the Solution Explorer and start debugging.
    public class LocatorSearchService : ILocatorSearchService
    {
        LocatorSearchDatas datas = new LocatorSearchDatas();
        public NetworkRevenueContract GetNetworkRevenues()
        {

            NetworkRevenueContract networkRevenue = new NetworkRevenueContract();
            return networkRevenue.GetNetworkRevenue(datas.networkRevenues);
        }

        public NetworksStatusContract GetNetworkStatusReport()
        {
            NetworksStatusContract networkStatus = new NetworksStatusContract();
            return networkStatus.GetNetworkStatusGraph(datas.networks);
        }
    }
}
