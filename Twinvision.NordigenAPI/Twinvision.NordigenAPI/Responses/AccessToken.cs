using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Responses
{
    public class AccessToken
    {
        [JsonProperty("access")]
        public string Access { get; set; }
        [JsonProperty("access_expires")]
        public int AccessExpires { get; set; }
        [JsonProperty("refresh")]
        public string Refresh { get; set; }
        [JsonProperty("refresh_expires")]
        public object RefreshExpires { get; set; }
    }
}