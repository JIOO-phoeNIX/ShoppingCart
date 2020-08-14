using ShoppingCart.DataAccess.Models;
using ShoppingCart.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class HomeIndexViewModel
    {
        public Cart Cart { get; set; }

        public List<Category> Categories { get; set; }
    }

    public class HomeProductsViewModel
    {
        public List<Product> Products { get; set; }

        public Category Category { get; set; }
    }
}