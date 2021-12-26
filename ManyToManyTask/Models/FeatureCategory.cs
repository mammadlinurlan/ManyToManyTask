using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class FeatureCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<FeaturedCategoryCard> FeaturedCategoryCards { get; set; }
    }
}
