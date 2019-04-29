using GraphQlLearning.Data;
using GraphQlLearning.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.Repositories
{
    public class ProductReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductReview> GetForProduct(int prodId)
        {
            return _context.ProductReviews.Where(p => p.ProductId == prodId);
        }
    }
}
