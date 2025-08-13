using EPiServer.Core;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCMSTest.Models.Pages;
using System;

namespace EPiServer.Reference.Commerce.Site.Features.Shared.Controllers
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