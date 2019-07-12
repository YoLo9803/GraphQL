using GraphQL;

namespace GraphStudy.Api.Schema
{
    public class GraphStudySchema : GraphQL.Types.Schema
    {
        public GraphStudySchema(IDependencyResolver dependencyResolver)
        {
            DependencyResolver = dependencyResolver;
        }
    }
}
