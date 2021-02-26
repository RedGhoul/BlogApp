using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagValue { get; set; }
        public ICollection<BlogTag> BlogTag { get; set; }
    }
}
