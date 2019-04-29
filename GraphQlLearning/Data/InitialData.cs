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
                var product = new Entities.Product
                {
                    Name = "test1",
                    Stock = 5,
                    Price = 100,
                    Rating = 4,
                    Type = ProductTypes.Boots,
                    Description = "About boots"
                };
                context.Products.Add(product);
                context.SaveChanges();

                context.ProductReviews.Add(new Entities.ProductReview
                {
                    ProductId = product.Id,
                    Review = "good",
                    Title = "fine"
                });

                context.SaveChanges();
            }
        }
    }
}
