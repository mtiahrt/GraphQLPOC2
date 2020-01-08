using GraphQL;

namespace Groups.Schema
{
    public class GroupsSchema : GraphQL.Types.Schema
    {
        public GroupsSchema(GroupsQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }
    }
}
