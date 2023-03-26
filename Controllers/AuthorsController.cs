using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Controllers
{
    internal class AuthorsController : Controller<Author>
    {
        public AuthorsController(DBContext context) : base(context)
        {
        }
    }
}
