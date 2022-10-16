using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class SKU //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        [MaxLength(16)]
        public decimal OldPrice { get; set; }
        [Required]
        [MaxLength(16)]
        public decimal Price { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public bool Status { get; set; }
        //public DateTime CreationDate { get; set; }
    }
}
