using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Categories = _context.Categories
            .OrderBy(x=> x.CategoryName)
            .ToList();
        
        return View("Movies", new AddMovie());
    }

    [HttpPost]
    public IActionResult Movies(AddMovie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
                    _context.SaveChanges();
                    
                    return View("Confirmation", response);
        }
        else
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x=> x.CategoryName)
                .ToList();
            
            return View(response); 
        }
        
    }

    public IActionResult Archive()
    {
        var movieList = _context.Movies
            .Include(x=>x.Category)
            .ToList();
        
        return View(movieList);
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x=> x.CategoryName)
            .ToList();
        
        return View("Movies", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(AddMovie updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges(); 
        
        return RedirectToAction("Archive");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);
        
        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(AddMovie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        
        return RedirectToAction("Archive");
    }
}
