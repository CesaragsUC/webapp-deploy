using System.Configuration;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaWebApp.Models;

namespace MinhaWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    public HomeController(ILogger<HomeController> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        ViewData["Grretings"] = _configuration["Greetings:Message"];

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult LancarErro()
    {
        throw new Exception("Teste de erro Aplication Insight.");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
