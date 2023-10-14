using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }
        [Route("[action]/{start}/{end?}/{id?}")]
        public IActionResult Countdown(int start, int end=0,string message=" ")
        {
            string contentString = "Counting down:\n";
            for (int i = 0;i>=0;i--) {
                contentString += i + "\n";
                    }
            return Content(contentString);
        }
        public IActionResult Display(string id)
        {
            if (id == null) {
                return Content("No ID supplied.");
            }
            else {
                return Content("ID: " + id);
            }
        }
    }
}