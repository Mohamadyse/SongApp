using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aghanina.Models;
using Aghanina.ViewModels;

namespace Aghanina.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Display()
        {
            var song = new Song();
            var randomPlayerViewModel = new RandomPlayerViewModel { Artist = new Artist { name = "Adel" } };
            return View(randomPlayerViewModel);
        }

    //    public IActionResult About()
    //    {
    //        ViewData["Message"] = "Your application description page.";

    //        return View();
    //    }

    //    public IActionResult Contact()
    //    {
    //        ViewData["Message"] = "Your contact page.";

    //        return View();
    //    }

    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    }
}
