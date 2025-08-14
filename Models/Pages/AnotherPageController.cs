using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace OptimizelyCMSTest.Models.Pages;

public class AnotherPageController : PageController<AnotherPage>
{
    public IActionResult Index(AnotherPage currentContent)
    {
        return View(currentContent);
    }
}
