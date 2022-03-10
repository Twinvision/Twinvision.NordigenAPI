using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public sealed class DebtorAccount
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }

    public sealed class TransactionAmount
    {
        [JsonProperty("amount")]
        public Decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public sealed class Booked
    {
        [JsonProperty("bankTransactionCode")]
        public string BankTransactionCode { get; set; }

        [JsonProperty("bookingDate")]
        public DateTime BookingDate { get; set; }

        [JsonProperty("debtorAccount")]
        public DebtorAccount DebtorAccount { get; set; }

        [JsonProperty("debtorName")]
        public string DebtorName { get; set; }

        [JsonProperty("remittanceInformationUnstructured")]
        public string RemittanceInformationUnstructured { get; set; }

        [JsonProperty("transactionAmount")]
        public TransactionAmount TransactionAmount { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("valueDate")]
        public DateTime ValueDate { get; set; }
    }

    public sealed class Pending
    {
        [JsonProperty("valueDate")]
        public DateTime ValueDate { get; set; }

        [JsonProperty("transactionAmount")]
        public TransactionAmount TransactionAmount { get; set; }

        [JsonProperty("remittanceInformationUnstructured")]
        public string RemittanceInformationUnstructured { get; set; }
    }

    public sealed class Transactions
    {
        [JsonProperty("booked")]
        public List<Booked> Booked { get; set; }

        [JsonProperty("pending")]
        public List<Pending> Pending { get; set; }
    }

    public sealed class Transaction
    {
        [JsonProperty("transactions")]
        public Transactions Transactions { get; set; }
    }

}
