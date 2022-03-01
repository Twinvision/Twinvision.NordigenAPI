﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenAPI.Requests
{
    public sealed class AgreementRequest
    {
        [JsonProperty("max_historical_days")]
        public int MaxHistoricalDays { get; set; }

        [JsonProperty("access_valid_for_days")]
        public int AccessValidForDays { get; set; }

        [JsonProperty("access_scope")]
        public List<string> AccessScope { get; set; }

        [JsonProperty("institution_id")]
        public Guid InstitutionId { get; set; }
    }
}
