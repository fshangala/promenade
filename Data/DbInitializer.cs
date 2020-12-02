using Promenade.Models;
using System;
using System.Linq;

namespace Promenade.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PromenadeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category{Name="Beverage", Image="/media/default.jpg"},
                new Category{Name="Salads", Image="/media/default.jpg"},
                new Category{Name="Meat", Image="/media/default.jpg"},
            };
            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();
        }
    }
}