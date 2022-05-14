using LaMiaPizzeria.BusinessLogic;
using LaMiaPizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaMiaPizzeria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;
        private ServizioPizza _service;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
            _service = new ServizioPizza();
        }

        public IActionResult Index()
        {
            List<PizzaViewModel> lista = _service.Pizze; 
            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dettaglio(int? id)
        {
            List<PizzaViewModel> lista = _service.Pizze;
            PizzaViewModel result = new PizzaViewModel();
            foreach (var item in lista)
            {
                if(item.Id == id)
                {
                    result = item;
                    break;
                }
            }

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}