using GraphQL;

namespace GraphStudy.Menu.Schema
{
    /// <summary>
    /// Menu的GraphQL Schema
    /// </summary>
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(IDependencyResolver dependencyResolver,MenuQuery menuQuery)
        {
            DependencyResolver = dependencyResolver;
            Query = menuQuery;
        }
    }
}
