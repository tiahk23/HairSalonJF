using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Models
{
    public class Appointment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
