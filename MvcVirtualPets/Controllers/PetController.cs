using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Controllers
{
    public class PetController : Controller
    { // Field
        Dictionary <int, Pet> pets = new Dictionary<int, Pet>()
            {
                {1,new Pet() { Id = 1, Name = "Roscoe" } },
                {2, new Pet() { Id = 2, Name = "Biggs" } },
                {3, new Pet() { Id = 3, Name = "Bella" } }
            };

           public ViewResult Index()
        {
           IEnumerable<Pet> model = pets.Values.ToList();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = pets[id];
            return View(model);
        }
    }
}
