using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories.Concrete
{
    public class Cart
    {
        /// <summary>
        /// A List that is used to store the Items temporarly
        /// </summary>
        private readonly List<CartLine> lineCollection = new List<CartLine>();

        /// <summary>
        /// Add an item to the cart, if the item already exit in the cart, increase the quantity by 1.
        /// </summary>
        /// <param name="product">The item to add to cart</param>
        /// <param name="quantity">The quantity of the item</param>
        public void AddItem(Product product, int quantity)
        {
            //Create a new CartLine for the item and check if the item already exist
            CartLine line = lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        /// <summary>
        /// Remove an item from the cart only if the item exist in the cart
        /// </summary>
        /// <param name="product">The item to remove</param>
        public void RemoveItem(Product product)
        {
            //Create a CartLine to check if the item exist in the cart
            CartLine line = lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();

            if (line != null)
            {
                lineCollection
                    .RemoveAll(p => p.Product.ProductID == product.ProductID);
            }
        }

        /// <summary>
        /// Get the total price of the item(s) in the cart
        /// </summary>
        /// <returns>The total price</returns>
        public decimal ComputeTotalValue()
        {
            return lineCollection
                .Sum(e => e.Product.Price * e.Quantity);
        }

        /// <summary>
        /// Remove all the item(s) in the cart
        /// </summary>
        public void Clear()
        {
            lineCollection.Clear();
        }

        /// <summary>
        /// Get the Cart List
        /// </summary>
        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    /// <summary>
    /// This class is used to store the item(s) in the cart. Each item in the cart is represented as an object
    /// of this class.
    /// </summary>
    public class CartLine
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}

