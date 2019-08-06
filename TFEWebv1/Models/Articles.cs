using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFEWebv1.Models
{
    public class Articles
    {
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Content { get; set; }
        public String Description { get; set; }
    }
}
