using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class PricingCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public List<PricingCardFeatures> PricingCardFeatures { get; set; }

        

    }
}
