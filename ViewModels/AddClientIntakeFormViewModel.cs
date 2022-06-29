using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HairSalonJF.ViewModels
{
    public class AddClientIntakeFormViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public string Age { get; set; }

        [Required(ErrorMessage = "Service is required.")]
        public string Service { get; set; }

    }
}
