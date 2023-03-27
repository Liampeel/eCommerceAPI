using System;
using System.ComponentModel.DataAnnotations;
using eCommerce.Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Data.Dtos
{
    public class ProductDto
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public bool OnSale { get; set; }

        public int Discount { get; set; }

        public int Quantity { get; set; }

    }
}


