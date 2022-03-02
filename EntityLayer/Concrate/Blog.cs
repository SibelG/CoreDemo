using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public String BlogTitle { get; set; }
        public String BlogContent { get; set; }
        public DateTime CreateDate { get; set; }
        public  bool BlogStatus{ get; set; }
        public String BlogImage { get; set; }
        public String BlogSmallImage { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment>Comments { get; set; }
    }
}
