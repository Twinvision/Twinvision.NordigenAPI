using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenApi.Responses
{
    public sealed class DebtorAccount
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }

    public sealed class CreditorAccount
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public sealed class TransactionLine
    {
        [JsonProperty("bankTransactionCode")]
        public string BankTransactionCode { get; set; }

        [JsonProperty("bookingDate")]
        public DateTime BookingDate { get; set; }

        [JsonProperty("debtorAccount")]
        public DebtorAccount DebtorAccount { get; set; }

        [JsonProperty("debtorId")]
        public string DebtorId { get; set; }

        [JsonProperty("debtorName")]
        public string DebtorName { get; set; }

        [JsonProperty("creditorAccount")]
        public DebtorAccount CreditorAccount { get; set; }

        [JsonProperty("creditorId")]
        public string CreditorId { get; set; }

        [JsonProperty("creditorName")]
        public string CreditorName { get; set; }

        [JsonProperty("endToEndId")]
        public string EndToEndId { get; set; }

        [JsonProperty("entryReference")]
        public string EntryReference { get; set; }

        [JsonProperty("mandateId")]
        public string MandateId { get; set; }

        [JsonProperty("purposeCode")]
        public string PurposeCode { get; set; }

        [JsonProperty("remittanceInformationUnstructured")]
        public string RemittanceInformationUnstructured { get; set; }

        [JsonProperty("transactionAmount")]
        public TransactionAmount TransactionAmount { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("ultimateCreditor")]
        public string UltimateCreditor { get; set; }

        [JsonProperty("ultimateDebtor")]
        public string UltimateDebtor { get; set; }
        [JsonProperty("valueDate")]
        public DateTime ValueDate { get; set; }
    }

    public sealed class Transactions
    {
        [JsonProperty("booked")]
        public List<TransactionLine> Booked { get; set; }

        [JsonProperty("pending")]
        public List<TransactionLine> Pending { get; set; }
    }

    public sealed class Transaction
    {
        [JsonProperty("transactions")]
        public Transactions Transactions { get; set; }
    }

}
