using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenAPI.Responses
{
    public class Agreement
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("max_historical_days")]
        public int MaxHistoricalDays { get; set; }

        [JsonProperty("access_valid_for_days")]
        public int AccessValidForDays { get; set; }

        [JsonProperty("access_scope")]
        public string[] AccessScope { get; set; }

        [JsonProperty("accepted")]
        public DateTime Accepted { get; set; }

        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }
    }
}
