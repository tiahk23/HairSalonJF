using HairSalonJF.Data;
using HairSalonJF.Models;
using HairSalonJF.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Controllers
{
    public class ClientIntakeFormController : Controller
    {
        private ApplicationDbContext context;


        public ClientIntakeFormController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ClientIntakeForm> clientIntakeForms = context.ClientIntakeForms.ToList();
            context.SaveChanges();
            return View(clientIntakeForms);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddClientIntakeFormViewModel addClientIntakeFormViewModel = new AddClientIntakeFormViewModel();
            return View(addClientIntakeFormViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddClientIntakeFormViewModel addClientIntakeFormViewModel)
        {
            if (ModelState.IsValid)
            {
                ClientIntakeForm newClientIntakeForm = new ClientIntakeForm
                {
                    Name = addClientIntakeFormViewModel.Name,
                    Service = addClientIntakeFormViewModel.Service,
                    Age = addClientIntakeFormViewModel.Age
                };
                context.ClientIntakeForms.Add(newClientIntakeForm);
                context.SaveChanges();
                return Redirect("/ClientIntakeForm");
            }
            return View(addClientIntakeFormViewModel);
        }

        

    }

}

