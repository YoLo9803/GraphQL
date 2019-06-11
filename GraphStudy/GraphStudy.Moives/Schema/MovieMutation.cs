using GraphQL.Types;
using GraphStudy.Movies.Movies;
using GraphStudy.Movies.Services;
using System.Linq;

namespace GraphStudy.Movies.Schema
{
    public class MoviesMutation : ObjectGraphType
    {
        public MoviesMutation(IMovieService movieService)
        {
            Name = "Mutation";

            //返回型別為MovieType，所以Field<MovieType>
            FieldAsync<MovieType>
            (
                "createMovie",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<MovieInputType>>
                {
                    Name = "movie"//注意此處無需標點符號，不然會出錯
                }),
                resolve: async context =>
                {
                    var movieInput = context.GetArgument<MovieInput>("movie");//此處movie的字應該與arguments裡面的Name字一樣，模板為MovieInput
                    //用非同步處理下面Id自增
                    var movies = await movieService.GetAsyncs();
                    var maxId = movies.Select(x => x.Id).Max();

                    var movie = new Movie
                    {
                        Id = ++maxId,
                        Name = movieInput.Name,
                        Company = movieInput.Company,
                        ActorId = movieInput.ActorId,
                        MovieRating = movieInput.MovieRating,
                        ReleaseDate = movieInput.ReleaseDate
                    };
                    //檢查MovieService類中CreateAsync方法是否寫對，
                    var result = await movieService.CreateAsync(movie);
                    //返回結果，返回型別為MovieType，他裡面有Id屬性
                    return result;
                }
            );
        }
    }
}