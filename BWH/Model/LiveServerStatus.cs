using Newtonsoft.Json;

namespace BandwagonHelper
{
    public class LiveServerStatusJson : ServerStatusJson
    {
        [JsonProperty("ve_status")]
        public string Status { get; set; }

        [JsonProperty("ve_mac1")]
        public string MacAddress { get; set; }

        [JsonProperty("ssh_port")]
        public int SSHPort { get; set; }
        
        [JsonProperty("is_cpu_throttled")]
        public string CpuThrottled { get; set; }

        [JsonProperty("live_hostname")]
        public string LiveHostName { get; set; }
    }
}
