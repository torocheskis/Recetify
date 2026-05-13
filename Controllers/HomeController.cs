using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Recetify.Models;

namespace Recetify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.NombreChef = Receta.NombreChef;
        ViewBag.FechaN = Receta.FechaN;
        View.TipoC = Receta.Receta;
        ViewBag.Presupuesto = Receta.Presupuesto;
        ViewBag,Comensales = Receta.Comensales;
        return View();
    }
    
    public IActionResult Index()
    {

    }

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
