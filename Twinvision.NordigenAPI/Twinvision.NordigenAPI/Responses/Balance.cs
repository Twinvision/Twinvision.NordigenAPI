using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class Balance
    {
        [JsonProperty("balanceAmount")]
        public BalanceAmount BalanceAmount { get; set; }

        [JsonProperty("balanceType")]
        public string BalanceType { get; set; }

        [JsonProperty("referenceDate")]
        public string ReferenceDate { get; set; }


        public class Root
        {
            [JsonProperty("balances")]
            public List<Balance> Balances { get; set; }
        }
    }
    public class BalanceAmount
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
    public class Root
    {
        [JsonProperty("balances")]
        public List<Balance> Balances { get; set; }
    }
}
