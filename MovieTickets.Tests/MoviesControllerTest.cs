using Microsoft.AspNetCore.Mvc;
using MovieTickets.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MovieTickets.Tests
{
    public class MoviesControllerTest
    {
        private readonly MoviesController _controller;

        public MoviesControllerTest()
        {
            _controller = new MoviesController();
        }

        [Fact]
        public void IndexViewResultNotNull()
        {
            // Act
            Task<IActionResult> result = _controller.Index();

            // Assert
            Assert.NotNull(result);
        }
    }
}
