using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerce.Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerce.Data.Dtos
{
    public class OrderDto
    {
        public List<ProductDto> Products { get; set; }

        public CustomerDto Customer { get; set; }

    }
}

