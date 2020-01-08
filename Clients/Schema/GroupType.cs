using GraphQL.Types;
using Identity.Models;


namespace Identity.Schema
{
    public class GroupType : ObjectGraphType<Group>
    {
        public GroupType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Description);
            Field(c => c.PublicKey);
            Field(c => c. ClientId);
            Field(c => c.CreatedOn);
            Field(c => c.LastChangeOn);
            Field(c => c.RoleId);
            Field(c => c.ProjectId);
            Field(c => c.ClientGuid);
            Field(c => c.WorksapceGuid);
        }
    }
}
