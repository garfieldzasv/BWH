using Newtonsoft.Json;
using System.Collections.Generic;

namespace BandwagonHelper
{
    public class ServerStatusJson : ExecuteResultJson
    {
        [JsonProperty("vm_type")]
        public string VMType { get; set; }

        [JsonProperty("hostname")]
        public string HostName { get; set; }

        [JsonProperty("node_ip")]
        public string NodeIp { get; set; }

        [JsonProperty("node_alias")]
        public string NodeAlias { get; set; }

        [JsonProperty("node_location")]
        public string NodeLocation { get; set; }

        [JsonProperty("node_location_id")]
        public string NodeLocationId { get; set; }

        [JsonProperty("node_datacenter")]
        public string NodeDataCenter { get; set; }

        [JsonProperty("location_ipv6_ready")]
        public bool Ipv6Ready { get; set; }

        [JsonProperty("plan")]
        public string ServicePlan { get; set; }

        [JsonProperty("plan_monthly_data")]
        public long PlanMonthlyData { get; set; }

        [JsonProperty("monthly_data_multiplier")]
        public decimal MonthlyDataMultiplier { get; set; }

        [JsonProperty("plan_disk")]
        public decimal PlanDisk { get; set; }

        [JsonProperty("plan_ram")]
        public decimal PlanRam { get; set; }

        [JsonProperty("plan_swap")]
        public int PlanSwap { get; set; }

        [JsonProperty("plan_max_ipv6s")]
        public int PlanMaxIpv6s { get; set; }

        [JsonProperty("os")]
        public string OperatingSystem { get; set; }

        [JsonProperty("email")]
        public string UserEmail { get; set; }

        [JsonProperty("data_counter")]
        public decimal DataCounter { get; set; }

        [JsonProperty("data_next_reset")]
        public decimal DataNextReset { get; set; }

        [JsonProperty("ip_addresses")]
        public IList<string> IpAddresses { get; set; }

        [JsonProperty("rdns_api_available")]
        public bool RDNSApiAvailable { get; set; }

        [JsonProperty("ptr")]
        public object PTR { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
    }
}
