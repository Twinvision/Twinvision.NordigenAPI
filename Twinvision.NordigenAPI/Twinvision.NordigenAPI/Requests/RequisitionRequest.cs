using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi.Requests
{
    public sealed class RequisitionRequest
    {
        [JsonProperty("redirect")]
        public string Redirect { get; set; }
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }
        [JsonProperty("agreement")]
        public Guid? Agreement { get; set; } = null;
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [JsonProperty("user_language")]
        public string UserLanguage { get; set; }
        //[JsonProperty("ssn")]
        //public string SSN { get; set; }
        [JsonProperty("account_selection")]
        public bool AccountSelection { get; set; }
    }
}
