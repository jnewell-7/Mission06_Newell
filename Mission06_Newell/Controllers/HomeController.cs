using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Newell.Models;

namespace Mission06_Newell.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult GetToKnow()
    {
        return View();
    }
    public IActionResult Movies()
    {
        return View();
    }
    
}