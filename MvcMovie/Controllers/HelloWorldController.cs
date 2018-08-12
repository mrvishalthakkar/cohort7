using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        ////GET: /HelloWorld
        //public string Index()
        //{
        //    return "This is my default action change";
        //}

            public IActionResult Index()
        {
            return View();
        }

        //Get: /Welcome/
        public IActionResult Welcome(string name, int ID = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = ID;

            return View();

        }
    }
}