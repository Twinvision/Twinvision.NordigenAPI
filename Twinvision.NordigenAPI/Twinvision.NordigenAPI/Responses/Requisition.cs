using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class RequisitionStatus
    {
        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public sealed class Requisition
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("status")]
        public RequisitionStatus Status { get; set; }

        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        [JsonProperty("agreement")]
        public string Agreement { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("accounts")]
        public List<string> Accounts { get; set; }

        [JsonProperty("user_language")]
        public string UserLanguage { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("account_selection")]
        public bool AccountSelection { get; set; }
    }

}
