using GraphQL.Types;
using GraphStudy.Movies.Movies;

namespace GraphStudy.Movies.Schema
{
    public class MovieRatingEnum : EnumerationGraphType<MovieRating>
    {
        //先定義下建構函式,列表列舉的GraphQL
        public MovieRatingEnum()
        {
            Name = "MovieRating";//型別的名字
            Description = "";//型別的描述

            //將滑鼠置於AddValue上顯示name,description,value,[deprecationReason]  []的含義是可填可不填的意思
            AddValue(MovieRating.Unrated.ToString(), "Unrated", MovieRating.Unrated);
            AddValue(MovieRating.G.ToString(), "G", MovieRating.G);
            AddValue(MovieRating.PG.ToString(), "PG", MovieRating.PG);
            AddValue(MovieRating.PG13.ToString(), "PG13", MovieRating.PG13);
            AddValue(MovieRating.R.ToString(), "R", MovieRating.R);
            AddValue(MovieRating.NC17.ToString(), "NC17", MovieRating.NC17);
        }
    }
}