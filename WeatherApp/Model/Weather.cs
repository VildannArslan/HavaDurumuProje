using Newtonsoft.Json;

namespace WeatherApp.Model;

public class Weather
{
        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("wind")]
        public string Wind { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("forecast")]
        public List<Forecast> Forecast { get; set; }
}