using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_UoW.Models
{
    public class Post : BaseModel
    {
        [Required, Index(IsUnique = true), MaxLength(20)]
        public string Title { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;

        [Required]
        public virtual Author Auth { get; set; }
    }
}
