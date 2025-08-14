using EPiServer.Core;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCMSTest.Models.Pages;
using System;

namespace OptimizelyCMSTest.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
        //public IActionResult Index(StandardPage currentPage)
        //{
        //    return Content($"Page found! Title: {currentPage.Title}");
        //}
    }
}