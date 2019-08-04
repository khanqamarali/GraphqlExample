using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using graphqllesssion1.Models;
using graphqllesssion1.Models.GraphQL;
using GraphQL.Instrumentation;
using GraphQL.Types;

namespace GraphqlExample.Models.GraphQL
{
    public class CustomerGraphqlType : ObjectGraphType<Customer>
    {
        public CustomerGraphqlType()
        {
            Field(x => x.firstName).Description("customer first name");
            Field(x => x.lastName).Description("customer last name");
            Field(x => x.Purchases,type:typeof(ListGraphType<PurchaseGraphqlType>)).Description("Purchase list");
        }

        
    }

    
}
