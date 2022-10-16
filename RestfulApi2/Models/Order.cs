using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Order //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        [Required]
        [MaxLength(16)]
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        //public DateTime CreationDate { get; set; }
    }
}
