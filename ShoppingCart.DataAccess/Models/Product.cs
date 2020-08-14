using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
    }
}
