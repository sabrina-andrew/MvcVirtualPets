﻿using Microsoft.EntityFrameworkCore;
using MvcVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SRA226Pets;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(

               new Pet() { Id = 1, Name = "Roscoe", Description = "Roscoe is a handsome boy" },
               new Pet() { Id = 2, Name = "Biggs" , Description = "Biggs is a big dog"},
               new Pet() { Id = 3, Name = "Bella" , Description = "Bella is a pretty girl"} 
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
