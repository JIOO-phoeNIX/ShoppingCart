using Ninject;
using ShoppingCart.DataAccess.Repositories.Abstract;
using ShoppingCart.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IProductRepository>().To<ProductRepository>();
            kernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            kernel.Bind<ShoppingCartDbContext>().To<ShoppingCartDbContext>();
        }
    }
}