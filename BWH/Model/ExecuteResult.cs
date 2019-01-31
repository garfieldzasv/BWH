using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandwagonHelper
{
    public class ExecuteResultJson
    {
        [JsonProperty("error")]
        public int Error { get; set; }
    }
}
