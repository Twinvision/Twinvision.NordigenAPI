using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi.Requests
{
    public sealed class AcceptAgreementRequest
    {
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }
    }
}
