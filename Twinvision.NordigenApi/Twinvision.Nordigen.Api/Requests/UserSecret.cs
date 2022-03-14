using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi.Requests
{
    public sealed class UserSecret
    {
        [JsonProperty("secret_id")]
        public string Secret_id { get; set; }
        [JsonProperty("secret_key")]
        public string Secret_key { get; set; }
    }
}
