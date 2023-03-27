using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Data.Context
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public bool OnSale { get; set; } 

        public int Discount { get; set; }

        public int Quantity { get; set; }

        public virtual Order Order { get; set; }

    }
}


