using GraphQL.Types;
using GraphQlLearning.Data.Entities;
using GraphQlLearning.GraphQL.Types;
using GraphQlLearning.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.GraphQL
{
    public class ApplicationMutation : ObjectGraphType
    {
        public ApplicationMutation(ProductReviewRepository repo)
        {
            FieldAsync<ProductReviewType>(
                "createReview",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReviewInputType>> { Name = "review" }),
                resolve: async context =>
                {
                    var review = context.GetArgument<ProductReview>("review");
                    return await context.TryAsyncResolve(async c => await repo.AddReview(review));
                });
        }
    }
}
