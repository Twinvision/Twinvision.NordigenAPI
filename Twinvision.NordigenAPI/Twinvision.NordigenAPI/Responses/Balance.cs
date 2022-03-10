using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{

    public class Balance
    {
        [JsonProperty("balances")]
        public List<BalanceData> Balances { get; set; }
    }

    public sealed class BalanceData
    {
        [JsonProperty("balanceAmount")]
        public BalanceAmount BalanceAmount { get; set; }

        [JsonProperty("balanceType")]
        public string BalanceType { get; set; }

        [JsonProperty("referenceDate")]
        public string ReferenceDate { get; set; }

    }
    public class BalanceAmount
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
