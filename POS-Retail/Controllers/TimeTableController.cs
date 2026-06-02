using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    public class TimeTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
