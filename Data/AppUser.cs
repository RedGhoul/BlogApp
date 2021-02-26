using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
    public class AppUser : IdentityUser
    {
        public ICollection<Blog> Blogs { get; set; } = new List<Blog>();
    }
}
