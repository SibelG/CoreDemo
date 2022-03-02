using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public String WriterName { get; set; }
        public String WriterImage { get; set; }
        public bool  Status { get; set; }
        public String WriterAbout { get; set; }
        public String WriterMail { get; set; }
        public String WriterPass { get; set; }
    }
}
