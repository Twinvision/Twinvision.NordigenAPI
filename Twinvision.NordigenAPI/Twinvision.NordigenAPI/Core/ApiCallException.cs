using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twinvision.NordigenAPI
{
    public sealed class ApiCallException : Exception
    {
        public override string Message
        {
            get
            {
                var message = StatusCode + " " + Summary;
                if(!String.IsNullOrEmpty(Detail) && Summary != Detail)
                {
                    message += "\n\r{Detail}";
                }
                return message;
            }
        }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("detail")]
        public string Detail { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("status_code")]
        public string StatusCode { get; set; }
    }
}