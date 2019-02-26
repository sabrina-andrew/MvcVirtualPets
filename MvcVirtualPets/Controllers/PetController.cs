using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Models;
using MvcVirtualPets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Controllers
{
    public class PetController : Controller
    {

        PetRepository petRepo;
        public PetController(PetRepository petRepo)
        {
            this.petRepo = petRepo;
        }
           public ViewResult Index()
        {
           IEnumerable<Pet> model = petRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = petRepo.GetById(id);  //pets[id];
            return View(model);
        }
    }
}
