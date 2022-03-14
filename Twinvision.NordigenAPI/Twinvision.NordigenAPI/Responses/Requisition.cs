using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi.Responses
{
    public sealed class Requisition
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        [JsonProperty("agreement")]
        public Guid? Agreement { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("accounts")]
        public List<string> Accounts { get; set; }

        [JsonProperty("user_language")]
        public string UserLanguage { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("ssn")]
        public string SSN { get; set; }

        [JsonProperty("account_selection")]
        public bool AccountSelection { get; set; }
    }

}
