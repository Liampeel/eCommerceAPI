using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Data.Context
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public virtual Address Address { get; set; }

        public virtual Order Order { get; set; }

    }
}


