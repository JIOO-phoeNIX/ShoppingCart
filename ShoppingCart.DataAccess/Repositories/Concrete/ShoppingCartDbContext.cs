using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Concrete
{
    public class ShoppingCartDbContext : DbContext
    {
        /// <summary>
        /// The Product table context
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// The Category table context
        /// </summary>
        public DbSet<Category> Categories { get; set; }
    }
}
