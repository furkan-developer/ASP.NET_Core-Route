using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Route.Models;

namespace Route.Controllers;

[Route("[controller]/[action]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// /Home/Index
    /// /Home/Index/custom-route
    ///</summary>
    [Route("")]
    [Route("custom-route")] 
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// /Home/Privacy
    /// </summary>
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
