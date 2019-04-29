using GraphQL.Types;
using GraphQlLearning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlLearning.GraphQL.Types
{
    public class ProductTypeEnumType : EnumerationGraphType<ProductTypes>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}
