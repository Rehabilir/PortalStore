using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class OrderItem //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? SkuId { get; set; }
        public SKU SKU { get; set; }
        [Required]
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        [MaxLength(16)]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        public bool Status { get; set; }
        //public DateTime CreationDate { get; set; }
    }
}
