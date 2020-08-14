using ShoppingCart.DataAccess.Models;
using ShoppingCart.DataAccess.Repositories.Abstract;
using ShoppingCart.DataAccess.Repositories.Concrete;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel
            {
                Cart = GetCart(),
                Categories = _categoryRepository.GetAll()
            };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Products(int? id)
        {
            var category = _categoryRepository.Get(id);
            if(category == null)
            {
                Response.StatusCode = 404;
                return View("CategoryNotFound");
            }
            HomeProductsViewModel viewModel = new HomeProductsViewModel
            {
                Products = _productRepository.GetByCategoryId(id),
                Category = category
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddToCart(Product product)
        {
            Product checkProduct = _productRepository.Get(product.ProductID);

            if (checkProduct != null)
            {
                GetCart().AddItem(product, 1);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteFromCart(Product product)
        {
            Product checkProduct = _productRepository.Get(product.ProductID);

            if (checkProduct != null)
            {
                GetCart().RemoveItem(product);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// This method is used to get the Cart from the Session storage
        /// </summary>
        /// <returns>The Cart</returns>
        [NonAction]
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }
    }
}