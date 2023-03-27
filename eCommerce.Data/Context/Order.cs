using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Data.Context
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPrice { get; set; }

        public virtual ICollection<Product>? Products { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }


    }
}

