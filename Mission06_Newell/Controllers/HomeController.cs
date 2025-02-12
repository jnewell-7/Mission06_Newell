using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Newell.Models;

namespace Mission06_Newell.Controllers;

public class HomeController : Controller
{
    private MoviesContext _context;
    
    public HomeController(MoviesContext temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult GetToKnow()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Movies()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Movies(AddMovie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        
        return View("Confirmation", response);
    }
    
}