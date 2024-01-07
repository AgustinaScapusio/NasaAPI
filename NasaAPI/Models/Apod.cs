using System.Text.Json.Serialization;

namespace NasaAPI.Models
{
    public class Apod
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("hdurl")]
        public string HdUrl{ get; set; }

        
    }
}
