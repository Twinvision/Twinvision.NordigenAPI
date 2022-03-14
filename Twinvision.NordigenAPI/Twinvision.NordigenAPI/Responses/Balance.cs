using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public enum BalanceType : int
    {
        [JsonProperty("closingBooked")]
        ClosingBooked,
        [JsonProperty("expected")]
        Excepected,
        [JsonProperty("forwardAvailable")]
        ForwardAvailable,
        [JsonProperty("interimAvailable")]
        InterimAvailable,
        [JsonProperty("interimBooked")]
        InteremBooked,
        [JsonProperty("nonInvoiced")]
        NonInvoiced,
        [JsonProperty("openingBooked")]
        OpeningBooked
    }

    public class Balance
    {
        [JsonProperty("balances")]
        public List<BalanceLine> Balances { get; set; }
    }

    public sealed class BalanceLine
    {
        [JsonProperty("balanceAmount")]
        public BalanceAmount BalanceAmount { get; set; }

        [JsonProperty("balanceType")]
        public BalanceType BalanceType { get; set; }

        [JsonProperty("referenceDate")]
        public DateTime ReferenceDate { get; set; }

    }
    public class BalanceAmount
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
