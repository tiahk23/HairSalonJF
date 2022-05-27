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
        public object Id { get; internal set; }

        [HttpGet]
        [Route("/ClientIntakeForm/")]
        public IActionResult Index()
        {
            List<ClientIntakeForm> intakeList = new List<ClientIntakeForm>();

            intakeList.Add(new ClientIntakeForm() { Name = "Client1", CurrentHairStyle = "Short", SpecialAccomidations = "None" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client2", CurrentHairStyle = "Long", SpecialAccomidations = "N/A" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client3", CurrentHairStyle = "Bangs, long", SpecialAccomidations = "Wheelchair" });

            intakeList.Add(new ClientIntakeForm() { Name = "Client4", CurrentHairStyle = "Bangs, short", SpecialAccomidations = "Allergic to plastic" });

            return View(intakeList);
        }
    }
}
