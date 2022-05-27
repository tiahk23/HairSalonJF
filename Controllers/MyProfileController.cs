using HairSalonJF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Controllers
{
    public class MyProfileController : Controller
    {
        public object Id { get; internal set; }

        [HttpGet]
        [Route("/MyProfile/")]
        public IActionResult Index()
        {
            // string html = "<h1>" + "Please fill out this form if you are a new client." + "<h1>";
            // return Content(html, "text/html");
            List<MyProfile> intakeList = new List<MyProfile>();

            intakeList.Add(new MyProfile() { Name = "Client1", CurrentHairStyle = "Short", SpecialAccomidations = "None" });
            return View(intakeList);
        }
    }
}
