using GraphQL.Types;
using Groups.Services;

namespace Groups.Schema
{
    public class GroupsQuery : ObjectGraphType<object> 
    {
        public GroupsQuery(IGroupService groups)//exposes a query that returns our groups
        {
            Name = "Query";
            Field<ListGraphType<GroupType>>("groups", resolve: context => groups.GetGroupsAsync());
        }
    }
}
