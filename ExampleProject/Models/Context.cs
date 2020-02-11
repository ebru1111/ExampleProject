using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class Context : DbContext
    {
        public Context()
        {

            Database.Connection.ConnectionString = "server = .; database = ExampleProjeDb; Integrated Security=True";
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
