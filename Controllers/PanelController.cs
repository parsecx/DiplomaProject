using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;

namespace AdmiPanel_HealthApp.Controllers;

public class PanelController: Controller
{
    private readonly ILogger<HomeController> _logger;

    public PanelController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Main()
    {
        ViewBag.MyVariable = "It's main page";
        return View();
    }

    public IActionResult Applications()
    {
        return View();
    }
    
    public IActionResult Chatting()
    {
        return View();
    }

    public IActionResult Policies()
    {
        return View();
    }

    public IActionResult Stats()
    {
        return View();
    }
}