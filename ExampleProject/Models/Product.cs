using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int UserId { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public virtual User User { get; set; }


    }
}
