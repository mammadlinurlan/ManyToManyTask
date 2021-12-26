using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }
        public string Title  { get; set; }

        public string Desc { get; set; }

    }
}
