using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenApi.Requests
{
    public sealed class AgreementRequest
    {
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }
        
        [JsonProperty("max_historical_days")]
        public int MaxHistoricalDays { get; set; }

        [JsonProperty("access_valid_for_days")]
        public int AccessValidForDays { get; set; }

        [JsonProperty("access_scope")]
        public string[] AccessScope { get; set; }
    }
}
