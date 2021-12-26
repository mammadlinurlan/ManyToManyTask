using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class FeatureCard
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public List<FeaturedCategoryCard> FeaturedCategoryCards { get; set; }
    }
}
