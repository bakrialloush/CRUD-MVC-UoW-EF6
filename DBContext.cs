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
        const string SERVER = "(localdb)\\motakamel";
        const string DB_NAME = "TestUoW";
        public DBContext() : base($"Data Source={SERVER};Initial Catalog={DB_NAME};Integrated Security=true;") { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
