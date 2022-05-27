using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Models
{
    public class MyProfile : Controller
    {
        public string Name { get; internal set; }
        public string CurrentHairStyle { get; set; }
        public string SpecialAccomidations { get; set; }
    }
}
