using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenAPI.Requests
{
    public sealed class AgreementRequest
    {
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }
        
        [JsonProperty("max_historical_days")]
        public string MaxHistoricalDays { get; set; }

        [JsonProperty("access_valid_for_days")]
        public string AccessValidForDays { get; set; }

        [JsonProperty("access_scope")]
        public string[] AccessScope { get; set; }
    }
}
