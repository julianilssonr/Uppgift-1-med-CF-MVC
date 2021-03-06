using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift_1_med_CF_MVC.Controllers
{
    public class PhotosController : Controller
    {
        //test kommentar
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cosmos()
        {
            return View();
        }

        public IActionResult Dahlia()
        {
            return View();
        }

        public IActionResult Lotus()
        {
            return View();
        }

        //use parameter to pass in photo id
        public ActionResult photoView(string id)
        {
            ViewBag.photo = id;
            return View();
        }
    }
}
