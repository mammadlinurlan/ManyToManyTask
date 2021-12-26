using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Icon { get; set; }

        public string Adress { get; set; }
        public string Phone { get; set; }

        public string Link { get; set; }

        public string Email { get; set; }
    }
}
