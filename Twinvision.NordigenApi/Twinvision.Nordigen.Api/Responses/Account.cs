using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenApi.Responses
{
    public enum AccountStatus : int
    {
        [JsonProperty("READY")]
        Ready,
        [JsonProperty("DISCOVERED")]
        Discovered,
        [JsonProperty("PROCESSING")]
        Processing,
        [JsonProperty("ERROR")]
        Error,
        [JsonProperty("EXPIRED")]
        Expired,
        [JsonProperty("SUSPENDED")]
        Suspended
    }

    public sealed class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("last_accessed")]
        public DateTime? LastAccessed { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        [JsonProperty("status")]
        public AccountStatus Status { get; set; }
    }
}
