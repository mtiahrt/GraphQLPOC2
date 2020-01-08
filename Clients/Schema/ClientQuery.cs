using GraphQL.Types;
using Identity.Services;

namespace Identity.Schema
{
    public class ClientQuery : ObjectGraphType<object>
    {
        public ClientQuery(IClientService clients)
        {
            Name = "Query";
            Field<ListGraphType<ClientQuery>>("clients", resolve: context => clients.GetClientsAsync());
        }

    }
}
