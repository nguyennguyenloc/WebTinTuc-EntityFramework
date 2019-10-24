using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTinTuc_EntityFramework.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostTeaser { get; set; }
        public int ViewCount { get; set; }
    }
}
