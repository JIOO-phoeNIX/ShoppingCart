using ShoppingCart.DataAccess.Models;
using ShoppingCart.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingCartDbContext dbContext;
        private readonly CategoryRepository _categoryRepository;

        public ProductRepository(ShoppingCartDbContext dbContext, CategoryRepository categoryRepository)
        {
            this.dbContext = dbContext;
            _categoryRepository = categoryRepository;
        }

        public List<Product> GetByCategoryId(int? categoryId)
        {
            //Check if the category exist
            var checkCategory = _categoryRepository.Get(categoryId);

            if (checkCategory != null)
                return dbContext.Products
                    .Where(p => p.CategoryId == categoryId)
                    .ToList();
            else
                return null;
        }

        public Product Get(int? productID)
        {
            var product = dbContext.Products
                .SingleOrDefault(p => p.ProductID == productID);

            if (product != null)
                return product;
            else
                return null;
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }
    }
}
