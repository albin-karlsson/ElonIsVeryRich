using ElonIsVeryRich.Api;
using ElonIsVeryRich.Logic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElonIsVeryRich.Pages
{
    public class IndexModel : PageModel
    {
        public int? TotalCost { get; set; }

        public async Task OnGet()
        {
            TimeSpan timeDifference = DateTime.Now - ApiCaller.GetLaunchesDate;

            if (ApiCaller.Launches == null || timeDifference.TotalDays > 5)
            {
                await new ApiCaller().GetLaunches();
            }
        }

        public async Task OnPost()
        {
            // Vi måste ha Launches och Rockets för att räkna ut kostnaden

            if (ApiCaller.Launches == null || ApiCaller.Rockets == null)
            {
                await new ApiCaller().GetLaunches();
                await new ApiCaller().GetRockets();
            }

            // Räkna ut kostnaden!
            TotalCost = new CostManager().CalculateTotalCost();
        }
    }
}
