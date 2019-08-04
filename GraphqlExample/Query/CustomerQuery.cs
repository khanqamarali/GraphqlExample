using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphqllesssion1.Models;
using GraphqlExample.Models.GraphQL;
using GraphQL.Language.AST;
using GraphQL.Types;

namespace GraphqlExample.Query
{
    public class CustomerQuery : ObjectGraphType
    {
        public CustomerQuery()
        {
            Field<CustomerGraphqlType>(
                "CustomerInfo",                
                resolve: context => { return getCustomer(); }
            );

        }

        public  Customer getCustomer()
        {
            var purchase = new Purchase(){prodId = 1,prodName = "A"};
            List<Purchase> p = new List<Purchase>();
            p.Add(purchase);

            return  new Customer{ firstName= "Elon",lastName = "Musks", Purchases = p };

        }
    }
}
