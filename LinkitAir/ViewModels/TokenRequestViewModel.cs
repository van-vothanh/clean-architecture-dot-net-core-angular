using System.Text.Json.Serialization;

namespace LinkitAir.ViewModels
{
    public class TokenRequestViewModel
    {
        [JsonPropertyName("grant_type")]
        public string grant_type { get; set; }
        
        [JsonPropertyName("client_id")]
        public string client_id { get; set; }
        
        [JsonPropertyName("client_secret")]
        public string client_secret { get; set; }
        
        [JsonPropertyName("username")]
        public string username { get; set; }
        
        [JsonPropertyName("password")]
        public string password { get; set; }
    }
}
