using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Partner> Partners { get; set; }

        public DbSet<AboutUsCard> AboutUsCards { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<MoreService> MoreServices { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<FeatureCard> FeatureCards { get; set; }

        public DbSet<FeatureCategory> FeatureCategories { get; set; }

        public DbSet<FeaturedCategoryCard> FeaturedCategoryCards { get; set; }

        public DbSet<TeamCard> TeamCards { get; set; }

        public DbSet<Social> Socials { get; set; }

        public DbSet<PricingFeature> PricingFeatures { get; set; }

        public DbSet<PricingCard> PricingCards { get; set; }

        public DbSet<PricingCardFeatures> PricingCardFeatures { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Contact> Contacts { get; set; }

    }
}
