using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(20)]
        public string UserName { get; set; }
        [Required, MaxLength(30)]
        public string Surname { get; set; }
        [Required, MaxLength(300)]
        public string Address { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        public int Phone { get; set; }
        public List<Product> Products { get; set; }
        public List<Bill> Bills { get; set; }

    }
}
