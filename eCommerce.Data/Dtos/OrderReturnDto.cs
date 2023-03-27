using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerce.Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerce.Data.Dtos
{
    public class OrderReturnDto : OrderDto
    {
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

    }
}

