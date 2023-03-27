using System;
using System.ComponentModel.DataAnnotations;
using eCommerce.Data.Context;

namespace eCommerce.Data.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; }

        public AddressDto Address { get; set; }

    }
}

