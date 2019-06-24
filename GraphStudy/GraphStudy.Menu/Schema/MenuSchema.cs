using GraphQL;

namespace GraphStudy.Menu.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(IDependencyResolver dependencyResolver,MenuQuery menuQuery)
        {
            DependencyResolver = dependencyResolver;
            Query = menuQuery;
        }
    }
}
