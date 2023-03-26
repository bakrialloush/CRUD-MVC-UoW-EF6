using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Controllers
{
    internal class PostsController : Controller<Post>
    {
        public PostsController(DBContext context) : base(context)
        {
        }
    }
}
