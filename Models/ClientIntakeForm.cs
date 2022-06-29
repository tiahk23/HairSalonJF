using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonJF.Models
{
    public class ClientIntakeForm 
    {
           public string Name { get; set; }
           public string Age { get; set; }
           public string Service { get; set; }


           public int Id { get; set; }

           public ClientIntakeForm()
            {
            }
            public ClientIntakeForm(string name, string age, string service)
            {
                Name = name;
                Age = age;
                Service = service;
            }

            public override string ToString()
            {
                return Name;
            }

            public override bool Equals(object obj)
            {
                return obj is ClientIntakeForm clientIntakeForm &&
                       Name == clientIntakeForm.Name &&
                       Age == clientIntakeForm.Age &&
                       Service == clientIntakeForm.Service &&
                       Id == clientIntakeForm.Id;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Age, Name, Service, Id);
            }
        }


    }

