using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi
{
    public sealed class ApiCallSuccess
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("detail")]
        public string Detail { get; set; }
    }
}