using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.Data
{
    public static class InitialData
    {
        public static void Seed(this ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new Entities.Product
                {
                    Name = "test1",
                    Stock = 5,
                    Price = 100,
                    Rating = 4,
                    Type = ProductType.Boots,
                    Description = "About boots"
                });
                context.SaveChanges();
            }
        }
    }
}
