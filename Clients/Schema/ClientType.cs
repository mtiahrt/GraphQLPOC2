using GraphQL.Types;
using Identity.Models;

namespace Identity.Schema
{
    public class ClientType : ObjectGraphType<Client>
    {
        public ClientType()
        {
            Field(c => c.Id);
            Field(c => c.PublicKey);
            Field(c => c.Name);
            Field(c => c.FileSharePath);
            Field(c => c.CreatedOn);
            Field(c => c.LastUpdatedOn);
        }
    }
}
