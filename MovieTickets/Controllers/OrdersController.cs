﻿using BusinessLogic.Services.Base;
using BusinessLogic.Services.Cart;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MovieTickets.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesService _moviesService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IMoviesService moviesService, ShoppingCart shoppingCart)
        {
            _moviesService = moviesService;
            _shoppingCart = shoppingCart;
        }

        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _moviesService.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
