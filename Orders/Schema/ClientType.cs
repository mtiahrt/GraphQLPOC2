using GraphQL.Types;
using Groups.Models;

namespace Groups.Schema
{
    public class ClientType : ObjectGraphType<Client>//tells graphql.Net this is actually a graphql type
    {
        public ClientType()
        {
            Field(c => c.Id);//exposes the field 
            Field(c => c.Name);
        }
    }
}
