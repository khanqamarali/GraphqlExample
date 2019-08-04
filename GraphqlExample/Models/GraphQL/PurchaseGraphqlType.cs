using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace graphqllesssion1.Models.GraphQL
{
    public class PurchaseGraphqlType : ObjectGraphType<Purchase>
    {
        public PurchaseGraphqlType()
        {
            Name = "PurchaseGraphqlType";
            Field(x => x.prodId).Description("Product code");
            Field(x => x.prodName).Description("Pruchase Desc");            
        }
    }
}
