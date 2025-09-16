using System.Text.Json.Serialization;

namespace LinkitAir.ViewModels
{
    public class TokenResponseViewModel
    {
        [JsonPropertyName("token")]
        public string token { get; set; }
        
        [JsonPropertyName("expiration")]
        public int expiration { get; set; }
    }
}
