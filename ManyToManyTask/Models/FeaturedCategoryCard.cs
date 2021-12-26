using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class FeaturedCategoryCard
    {
        public int Id { get; set; }
        public int FeatureCardId { get; set; }

        public FeatureCard FeatureCard { get; set; }

        public int FeatureCategoryId { get; set; }

        public FeatureCategory FeatureCategory { get; set; }

    }
}
