﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Controllers
{
    public class SalonCalandarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
