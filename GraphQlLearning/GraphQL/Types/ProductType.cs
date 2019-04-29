using GraphQL.Types;
using GraphQlLearning.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
            Field(t => t.Price);
            Field(t => t.Rating);
            Field(t => t.Stock);
            Field(t => t.Type);
        }
    }
}
