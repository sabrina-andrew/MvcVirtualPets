using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Controllers;
using MvcVirtualPets.Models;
using MvcVirtualPets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using NSubstitute;

namespace MvcVirtualPets.Tests
{
    public class PetControllerTests
    {
        PetController underTest;
        private IPetRepository repo;

        public PetControllerTests()
        {            
            repo = Substitute.For<IPetRepository>();
            underTest = new PetController(repo);
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {            
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Pet>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Pet>)result.Model;
            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Pet();
            repo.GetById(expectedId).Returns(expectedModel);
         
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}

