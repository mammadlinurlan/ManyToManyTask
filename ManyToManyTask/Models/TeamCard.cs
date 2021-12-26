using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class TeamCard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public string Image { get; set; }
        public List<Social> Socials { get; set; }

    }
}
