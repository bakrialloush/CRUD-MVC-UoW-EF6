using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW
{
    internal class DBContext : DbContext
    {
        public DBContext() : base("Conn")
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
