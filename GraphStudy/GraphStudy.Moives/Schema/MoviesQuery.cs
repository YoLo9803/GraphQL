using GraphQL.Types;
using GraphStudy.Movies.Services;

namespace GraphStudy.Movies.Schema
{
    //查詢
    public class MoviesQuery : ObjectGraphType
    {
        public MoviesQuery(IMovieService movieService)
        {
            Name = "Query";
            QueryArgument argument = new QueryArgument<IntGraphType> { Name = "id" };
            //查詢所有Movie
            //Field<ListGraphType<MovieType>>("movies", resolve: context => { return new Movies.Movie { Id = 1, Name = "書" }; });
            Field<ListGraphType<MovieType>>("movies", resolve: context => movieService.GetAsyncs());
            //Field<MovieType>("movies", resolve: context => { var id = context.GetArgument<int>("id"); return movieService.GetByIdAsync(1); });
        }
    }
}