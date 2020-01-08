using GraphQL;

namespace Identity.Schema
{
    public class ClientSchema : GraphQL.Types.Schema
    {
        public ClientSchema(ClientQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }
    }
}
