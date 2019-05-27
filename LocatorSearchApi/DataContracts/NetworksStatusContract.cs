using LocatorSearchApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LocatorSearchApi.DataContracts
{
    [DataContract]
    public class NetworksStatusContract
    {
        [DataMember]
        public List<GraphData> networkStatus { get; set; }

        [DataMember]
        public List<GraphData> clientNetworkStatus { get; set; }

        [DataMember]
        public List<GraphData> nonClientNetworkStatus { get; set; }

        public NetworksStatusContract GetNetworkStatusGraph(List<Networks> networks) {

          this.networkStatus= networks.GroupBy(x => x.status).Select(x => new GraphData { key = x.Key, value = x.Count() }).ToList<GraphData>();

            var clientNetworks = networks.Where(item => item.isClientNetwork).ToList<Networks>();

            this.clientNetworkStatus =clientNetworks.GroupBy(x=>x.status).Select(x=> new GraphData { key= x.Key, value = x.Count() }).ToList<GraphData>();

            var noNClientNetworks = networks.Where(item => !item.isClientNetwork).ToList<Networks>();

            nonClientNetworkStatus = noNClientNetworks.GroupBy(x => x.status).Select(x => new GraphData { key = x.Key, value = x.Count() }).ToList<GraphData>();

            return this;
        }
    }
}