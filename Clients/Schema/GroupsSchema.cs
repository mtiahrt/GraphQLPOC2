using GraphQL;

namespace Identity.Schema
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
