using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class PricingCardFeatures
    {
        public int Id { get; set; }
        public int PricingCardId { get; set; }

        public PricingCard PricingCard { get; set; }
        public int PricingFeatureId { get; set; }

        public PricingFeature PricingFeature { get; set; }




    }
}
