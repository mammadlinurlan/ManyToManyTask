using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class PricingFeature
    {
        public int Id { get; set; }

        public string First { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }

        public string Fourth { get; set; }
        public string Fifth { get; set; }

        public List<PricingCardFeatures> PricingCardFeatures { get; set; }

    }
}
