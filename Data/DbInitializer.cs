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
                new Category{Name="Beverage", Image="/media/default.png"},
                new Category{Name="Salads", Image="/media/default.png"},
                new Category{Name="Meat", Image="/media/default.png"},
            };
            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();

            if (context.Details.Any())
            {
                return;   // DB has been seeded
            }

            var details = new Details[]
            {
                new Details{Name="Privacy Policy", Value="Site Privacy Policy", Type="Policy"},
                new Details{Name="Description", Value="Promenade restaurant", Type="About"},
                new Details{Name="E-mail", Value="admin@promenaderestaurant.com", Type="Contact"},
                new Details{Name="Phone", Value="+123243728", Type="Contact"},
                new Details{Name="Address", Value=". . .", Type="Contact"},
            };
            foreach (Details c in details)
            {
                context.Details.Add(c);
            }
            context.SaveChanges();
        }
    }
}