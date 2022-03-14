using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{

    public class AccountDetailLine
    {
        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("cashAccountType")]
        public string CashAccountType { get; set; }
    }

    public class AccountDetail
    {
        [JsonProperty("account")]
        public AccountDetailLine Account { get; set; }
    }
}
