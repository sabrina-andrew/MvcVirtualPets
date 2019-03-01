﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name="Pet Name")]
        public string Name { get; set; }
        [Display(Description = "Pet Description")]
        public string Description { get; set; }
    }
}
