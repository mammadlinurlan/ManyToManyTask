using ManyToManyTask.Models;
using ManyToManyTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyTask.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }





        public ActionResult Index()
        {
            HomeVM homevm = new HomeVM()
            {
                Settings = _context.Settings.ToList(),
                Partners = _context.Partners.ToList(),
                AboutUsCards = _context.AboutUsCards.ToList(),
                Services = _context.Services.ToList(),
                MoreServices = _context.MoreServices.ToList(),
                Features = _context.Features.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                FeatureCategories = _context.FeatureCategories.Include(fc => fc.FeaturedCategoryCards).ThenInclude(fc => fc.FeatureCard).ToList(),
                TeamCards = _context.TeamCards.Include(tc => tc.Socials).ToList(),
                PricingCardFeatures = _context.PricingCardFeatures.Include(ct => ct.PricingCard).Include(ct => ct.PricingFeature).ToList(),
                 Questions=_context.Questions.ToList(),
                  Contacts=_context.Contacts.ToList()


            };

            return View(homevm);
        }
    }
}
