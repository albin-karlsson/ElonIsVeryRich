using ElonIsVeryRich.Api;

namespace ElonIsVeryRich.Logic
{
    public class CostManager
    {
        public int? CalculateTotalCost()
        {
            int? totalCost = null;

            if (ApiCaller.Launches != null && ApiCaller.Rockets != null)
            {
                // Räkna ut kostanden
                totalCost = 0;

                foreach (var launch in ApiCaller.Launches)
                {
                    string? rocketName = launch.Rocket?.RocketName;

                    int? launchCost = ApiCaller.Rockets.FirstOrDefault(r => r.RocketName == rocketName)?.CostPerLaunch;

                    totalCost += launchCost;
                }
            }

            return totalCost;
        }
    }
}
