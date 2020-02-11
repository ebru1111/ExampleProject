using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public int UserId { get; set; }
        [Required, MaxLength(40)]
        public string BillNumber { get; set; }
        [Required, MaxLength(50)]
        public string BillDate { get; set; }
        public int Total { get; set; }
        public virtual User User { get; set; }

    }
}
