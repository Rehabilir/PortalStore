using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Category //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public bool Status { get; set; }
        //public DateTime CreationDate { get; set; }
        
    }
}
