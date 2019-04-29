using GraphQL.Types;
using GraphQlLearning.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.GraphQL.Types
{
    public class ProductReviewType: ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(i => i.Id);
            Field(i => i.ProductId);
            Field(i => i.Review);
            Field(i => i.Title);
        }
    }
}
