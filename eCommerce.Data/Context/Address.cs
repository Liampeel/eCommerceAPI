using System;
namespace eCommerce.Data.Context
{
    public class Address
    {
        public int Id { get; set; }

        public string ShippingAddress1 { get; set; }

        public string? ShippingAddress2 { get; set; }

        public string Postcode { get; set; }

        public string City { get; set; }

        public string? County { get; set; }

        public string EmailAddress { get; set; }

        public string? PhoneNumber { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

