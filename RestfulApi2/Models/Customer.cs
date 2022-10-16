using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Customer //veri tabanındaki tablolara karşılık geliyor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long TCID { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string GSM { get; set; }
        public bool Status { get; set; }
        //public DateTime CreationDate { get; set; }
    }
}
