using Newtonsoft.Json;
using WeatherApp.Model;

Dictionary<int, (string, string)> cityInformations = new Dictionary<int, (string, string)>();

cityInformations.Add(1, ("İstanbul", "https://goweather.herokuapp.com/weather/istanbul"));
cityInformations.Add(2, ("İzmir", "https://goweather.herokuapp.com/weather/izmir"));
cityInformations.Add(3, ("Ankara", "https://goweather.herokuapp.com/weather/ankara"));

var client = new HttpClient();

for (int i = 1; i <= cityInformations.Count; i++)
{
    var request = new HttpRequestMessage(HttpMethod.Get, cityInformations[i].Item2);

    HttpResponseMessage response = await client.SendAsync(request);

    response.EnsureSuccessStatusCode();

    var data = JsonConvert.DeserializeObject<Weather>(await response.Content.ReadAsStringAsync());

    Console.WriteLine("---------- " + cityInformations[i].Item1 + " ----------");
    if (data != null)
    {
        Console.WriteLine("TODAY");
        Console.WriteLine("Temp : " + data.Temperature);
        Console.WriteLine("Wind : " + data.Wind);
        Console.WriteLine("Description : " + data.Description);
        Console.WriteLine("-----------");
    
        if (data.Forecast != null)
        {
            foreach (var item in data.Forecast)
            {
                Console.WriteLine("Day : " + item.Day);
                Console.WriteLine("Temp : " + item.Temperature);
                Console.WriteLine("Wind : " + item.Wind);
                Console.WriteLine("-----------");
            }   
        }
    }  
}

