using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCMSTest.Models.Pages;

namespace OptimizelyCMSTest.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}