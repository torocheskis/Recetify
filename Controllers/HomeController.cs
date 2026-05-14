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

    public IActionResult GenerarReceta(Receta receta)
    {
        ViewBag.Nombre = receta.Nombre;
        ViewBag.Edad = receta.CalcEdad();
        ViewBag.Plato = receta.DeterminarComida();
        ViewBag.Tiempo = receta.CalcTiempo();
        ViewBag.Dificultad = receta.DeterminarDificultad();
        ViewBag.Comensales = receta.Comensales;
        return View("Resultado");
    }
    
    public IActionResult Index()
    {
        return View();
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
