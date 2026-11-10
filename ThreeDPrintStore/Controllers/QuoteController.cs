using Microsoft.AspNetCore.Mvc;

namespace ThreeDPrintStore.Controllers
{

    public class QuoteController : Controller
    {
        [HttpGet]
        public IActionResult RequestForm()
        {
        return View();
        }
    }
}