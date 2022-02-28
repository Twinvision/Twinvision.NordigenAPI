using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class Institution
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("bic")]
        public string BIC { get; set; }
        [JsonProperty("transaction_total_days")]
        public string TransactionTotalDays { get; set; }
        [JsonProperty("countries")]
        public string[] Countries { get; set; }
        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}
