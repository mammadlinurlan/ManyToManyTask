using ManyToManyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.ViewModels
{
    public class HomeVM
    {
        public List<Setting> Settings { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Service> Services { get; set; }
        public List<AboutUsCard> AboutUsCards { get; set; }

        public List<MoreService> MoreServices { get; set; }

        public List<Feature> Features { get; set; }

        public List<Testimonial> Testimonials { get; set; }

        public List<FeatureCategory> FeatureCategories { get; set; }

        public List<TeamCard> TeamCards { get; set; }

        public List<PricingCardFeatures> PricingCardFeatures { get; set; }

        public List<Question> Questions { get; set; }

        public List<Contact> Contacts { get; set; }

    }
}
