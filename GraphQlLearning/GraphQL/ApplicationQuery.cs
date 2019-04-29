using GraphQL.Types;
using GraphQlLearning.GraphQL.Types;
using GraphQlLearning.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.GraphQL
{
    public class ApplicationQuery : ObjectGraphType
    {
        public ApplicationQuery(ProductRepository repo)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => repo.GetAll()
                );

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> //or IdGraphType
                    {
                        Name = "id",
                    }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return repo.GetSingle(id);
                });
        }
    }
}
