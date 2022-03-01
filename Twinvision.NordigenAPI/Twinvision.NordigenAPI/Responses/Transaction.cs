using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class Transaction
    {
        [JsonProperty("balanceAmount")]
        public BalanceAmount BalanceAmount { get; set; }

        [JsonProperty("balanceType")]
        public string BalanceType { get; set; }

        [JsonProperty("referenceDate")]
        public string ReferenceDate { get; set; }

    }
}
