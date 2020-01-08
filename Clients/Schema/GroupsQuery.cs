using GraphQL.Types;
using Identity.Services;

namespace Identity.Schema
{
    public class GroupsQuery : ObjectGraphType<object>
    {
        public GroupsQuery(IGroupService groups)
        {
            Name = "Query";
            Field<ListGraphType<GroupType>>("groups", resolve: context => groups.GetGroupsAsync());
        }
    }
}
