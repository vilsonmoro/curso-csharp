﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovieCore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
           return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"); 
        }
    }
}