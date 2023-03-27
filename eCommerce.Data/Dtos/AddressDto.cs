using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Data.Dtos
{
    public class AddressDto
    {
        public string ShippingAddress1 { get; set; }

        public string? ShippingAddress2 { get; set; }

        public string Postcode { get; set; }

        public string City { get; set; }

        public string? County { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

    }
}

