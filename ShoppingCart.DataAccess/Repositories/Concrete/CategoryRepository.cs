using ShoppingCart.DataAccess.Models;
using ShoppingCart.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShoppingCartDbContext dbContext;

        public CategoryRepository(ShoppingCartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Category Get(int? categoryId)
        {
            var category = dbContext.Categories
                .SingleOrDefault(p => p.CategoryId == categoryId);

            if (category != null)
                return category;
            else
                return null;
        }

        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }
    }
}
