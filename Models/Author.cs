using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_UoW.Models
{
    internal class Author : BaseModel
    {
        [Required, Index(IsUnique = true), MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
