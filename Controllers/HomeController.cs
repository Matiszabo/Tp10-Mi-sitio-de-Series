using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp10_Mi_sitio_de_Series.Models;
using temp.Models;
using ser.Models;
using act.Models;
using basee.Models;

namespace Tp10_Mi_sitio_de_Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index(int idS)
    {
        ViewBag.Series =  BD.TraerSeries();
        return View();
    }

    public List<Actores> MostrarActoresAjax(int idSerie)
    {
        return BD.TraerActores(idSerie);
    }

    public Series MostrarInfoSeriesAjax(int idSerie)
    {
        return BD.verInfoSerie(idSerie);
    }

    public List<Temporadas> MostrarTemporadasAjax(int idSerie)
    {
        return BD.TraerTemporadas(idSerie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
