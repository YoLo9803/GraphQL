using GraphQL.Types;
using GraphStudy.Movies.Movies;
using GraphStudy.Movies.Services;

namespace GraphStudy.Movies.Schema
{
    public class MovieType : ObjectGraphType<Movie>
    {
        //先定義下建構函式
        public MovieType(IActorService actorService)
        {
            Name = "Movie";//型別的名字
            Description = "電影";//型別的描述

            Field(x => x.Id,nullable:false).Description("Movie's Id.");
            Field(x => x.Name);
            Field(x => x.Company);
            Field(x => x.ReleaseDate);
            Field(x => x.ActorId);

            //將列舉的Graph也加入其中,這是在查詢Movie中巢狀（學過sql應該懂得巢狀查詢）一個MovieRatingEnum
            //取名movieRating，查詢結果context.Source.MovieRating
            Field<MovieRatingEnum>("movieRating", resolve: context => context.Source.MovieRating);

            Field<ActorType>("Actor", resolve: context => actorService.GetByIdAsync(context.Source.ActorId));

            //做一個小小的測試
            Field<StringGraphType>("customString", resolve: context => "1234");
        }
    }
}