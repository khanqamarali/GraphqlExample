using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphqlExample.Query;
using Microsoft.AspNetCore.Mvc;
using GraphQL;
using GraphQL.Types;

namespace GraphqlExample.Controllers
{
    [Route("graphql")]
    public class GraphqlController : Controller
    {
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();
            var schema = new Schema()
            {
                Query = new CustomerQuery()
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            return Ok(result);
        }
    }
}
