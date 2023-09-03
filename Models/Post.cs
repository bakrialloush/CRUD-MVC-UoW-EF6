using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_UoW.Models
{
    internal class Post : BaseModel
    {
        [Required, Index(IsUnique = true), MaxLength(20)]
        public string Title { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public virtual Author Auth { get; set; }
    }
}
