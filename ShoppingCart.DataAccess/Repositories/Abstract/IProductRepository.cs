using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Abstract
{
    public interface IProductRepository
    {
       /// <summary>
       /// Get all the Products in the table
       /// </summary>
       /// <returns>A List containing all the Products</returns>
        List<Product> GetAll();

        /// <summary>
        /// Get a single product using the ProductID
        /// </summary>
        /// <param name="productID">The Id of the Product</param>
        /// <returns>The Product</returns>
        Product Get(int? productID);

        /// <summary>
        /// Get all the products that belongs to a Category
        /// </summary>
        /// <param name="categoryId">The Id of the Category</param>
        /// <returns>A list containing all the products in the Category</returns>
        List<Product> GetByCategoryId(int? categoryId);
    }
}
