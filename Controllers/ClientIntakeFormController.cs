using HairSalonJF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Controllers
{
    public class ClientIntakeFormController : Controller
    {
        [HttpGet]
        [Route("/ClientIntakeForm/")]
        public IActionResult Index()
        {
           // string html = "<h1>" + "Please fill out this form if you are a new client." + "<h1>";
               // return Content(html, "text/html");
            List<ClientIntakeForm> intakeList = new List<ClientIntakeForm>();

            intakeList.Add(new ClientIntakeForm() { Name = "Client1", CurrentHairStyle = "Short", SpecialAccomidations = "None" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client2", CurrentHairStyle = "Long", SpecialAccomidations = "N/A" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client3", CurrentHairStyle = "Bangs, long", SpecialAccomidations = "Wheelchair" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client4", CurrentHairStyle = "Bangs, short", SpecialAccomidations = "Allergic to plastic" });

            return View(intakeList);
        }
    }
}
