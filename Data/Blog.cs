using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
    public class Blog
    {
        public int Id { get; set; }
        [Column(TypeName = "TEXT")]
        public string Title { get; set; }

        [Column(TypeName = "TEXT")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public bool Draft { get; set; }
        public ICollection<BlogTag> BlogTag { get; set; }

    }
}
