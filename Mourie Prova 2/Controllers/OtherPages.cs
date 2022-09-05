using Microsoft.AspNetCore.Mvc;
using Mourie_Prova_2.Models;
using System.Diagnostics;

namespace Mourie_Prova_2.Controllers
{
	public class OtherPages : Controller
	{
        private readonly ILogger<OtherPages> _logger;

        public OtherPages(ILogger<OtherPages> logger)
        {
            _logger = logger;
        }

        public IActionResult Collabora()
        {
            return View();
        }
        public IActionResult RltS()
        {
            return View();
        }
    }
}
