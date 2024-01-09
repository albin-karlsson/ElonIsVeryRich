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
            // Vi m�ste ha Launches och Rockets f�r att r�kna ut kostnaden

            if (ApiCaller.Launches == null || ApiCaller.Rockets == null)
            {
                await new ApiCaller().GetLaunches();
                await new ApiCaller().GetRockets();
            }

            // R�kna ut kostnaden!
            TotalCost = new CostManager().CalculateTotalCost();
        }
    }
}
