using LocatorSearchApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LocatorSearchApi.DataContracts
{
    [DataContract]
    public class NetworkRevenueContract
    {
        [DataMember]
        public List<GraphData> monthly { get; set; }

        [DataMember]
      public  List<GraphData> yearly {get;set;}

        [DataMember]
        public List<GraphData> quarterly { get; set; }

        public NetworkRevenueContract GetNetworkRevenue(List<NetworkRevenues> networkRevenues) {

            List<NetworkRevenueContract> networkRevenueList = new List<NetworkRevenueContract>();
            this.monthly = networkRevenues.GroupBy(x => new { x.revenueOn.Year, x.revenueOn.Month })
                .Select(x => 
                new GraphData
                {
                    key = x.Key.Month.ToString() + x.Key.Year.ToString(),
                    value = x.Sum(item => item.revenue) }).ToList<GraphData>();
            this.quarterly = networkRevenues
                .GroupBy(x => new { quater = (x.revenueOn.Month - 1) / 3, year = x.revenueOn.Year })
                .Select(x => new GraphData
                {
                    key = x.Key.quater.ToString() + x.Key.year.ToString(),
                    value = x.Sum(item => item.revenue)
                }).ToList<GraphData>();
            this.yearly = networkRevenues.GroupBy(x => x.revenueOn.Year).Select(x => new GraphData
            {
                key = x.Key.ToString(),
                value = x.Sum(item => item.revenue)
            }).ToList<GraphData>();

            
          
            return this;
        }
    }

    public class GraphData {
        public string key { get; set; }
        public int value { get; set; }
    }

 
    
}