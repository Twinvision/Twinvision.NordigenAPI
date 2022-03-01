using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class Account
    {
        public class Root
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }

            [JsonProperty("last_accessed")]
            public DateTime LastAccessed { get; set; }

            [JsonProperty("iban")]
            public string Iban { get; set; }

            [JsonProperty("institution_id")]
            public string InstitutionId { get; set; }

            [JsonProperty("status")]
            public Status Status { get; set; }
        }

        public class Status
        {
            [JsonProperty("DISCOVERED")]
            public string DISCOVERED { get; set; }
        }
    }
}
