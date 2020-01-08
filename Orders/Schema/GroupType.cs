using GraphQL.Types;
using Groups.Models;
using Groups.Services;

namespace Groups.Schema
{
    public class GroupType : ObjectGraphType<Group>
    {
        public GroupType(ICustomerService customers)
        {
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Discription);
            Field(o => o.ClientId);
            //this exposes the client field with the group query
            Field<ClientType>("client", resolve: context => customers.GetCustomerByIdAsync(context.Source.ClientId));
            Field(o => o.CreatedOn);
        }
    }
}
