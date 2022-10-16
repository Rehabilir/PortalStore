using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Address //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string AddressLine { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
        [Required]
        [MaxLength(30)]
        public string City { get; set; }
        [Required]
        [MaxLength(30)]
        public string District { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public bool Status { get; set; }
        
        //public DateTime CreationDate { get; set; }
    }
}
