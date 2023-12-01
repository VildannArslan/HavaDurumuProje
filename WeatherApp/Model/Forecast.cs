using Newtonsoft.Json;

namespace WeatherApp.Model;

public class Forecast
{
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("wind")]
        public string Wind { get; set; }
}