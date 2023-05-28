using System.Text.Json.Serialization;

namespace Banorte3.Models
{
    public class HomeResponse
    {
        [JsonPropertyName("homeElements")]
        public List<int> HomeElements { get; set; }
    }
}
