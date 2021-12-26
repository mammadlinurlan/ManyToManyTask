using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class AboutUsCard
    {
        public int Id { get; set; }
        public string Logo { get; set; }

        public int StartCount { get; set; }

        public int EndCount { get; set; }

        public string Desc { get; set; }
    }
}
