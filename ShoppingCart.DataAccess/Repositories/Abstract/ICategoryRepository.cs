using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Get a Category by the Id
        /// </summary>
        /// <param name="categoryId">The Id of the Category</param>
        /// <returns>The Category</returns>
        Category Get(int? categoryId);

        /// <summary>
        /// Get all the Categories in the table
        /// </summary>
        /// <returns>A List containing all the Categories</returns>
        List<Category> GetAll();
    }
}
