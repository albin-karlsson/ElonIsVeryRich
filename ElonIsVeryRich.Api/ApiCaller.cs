using ElonIsVeryRich.Domain;
using Newtonsoft.Json;

namespace ElonIsVeryRich.Api
{
    public class ApiCaller
    {
        public static DateTime GetLaunchesDate { get; set; }
        public static DateTime GetRocketsDate { get; set; }
        public static List<LaunchRoot>? Launches { get; set; }
        public static List<RocketRoot>? Rockets { get; set; }


        public async Task GetLaunches()
        {
            HttpClient client = new();

            var response = await client.GetAsync("https://api.spacexdata.com/v3/launches");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                List<LaunchRoot>? data = JsonConvert.DeserializeObject<List<LaunchRoot>>(json);

                Launches = data;
                GetLaunchesDate = DateTime.Now;
            }
        }

        public async Task GetRockets()
        {
            // Skapa en klient
            HttpClient client = new();

            // Gör själva callet
            var response = await client.GetAsync("https://api.spacexdata.com/v3/rockets");

            // Evaluera response
            if (response.IsSuccessStatusCode)
            {
                // Läs responset som json
                string json = await response.Content.ReadAsStringAsync();

                // Konvertera json till C#-objekt
                List<RocketRoot>? data = JsonConvert.DeserializeObject<List<RocketRoot>>(json);

                // Returnera C#-objekt
                Rockets = data;
                GetRocketsDate = DateTime.Now;
            }
        }
    }
}
