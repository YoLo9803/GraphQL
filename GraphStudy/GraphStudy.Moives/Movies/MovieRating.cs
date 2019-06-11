using System;

namespace GraphStudy.Movies.Movies
{
    [Flags]
    public enum MovieRating
    {
        //這是電影的5個等級
        Unrated = 0,
        G = 1,
        PG = 2,
        PG13 = 3,
        R = 4,
        NC17 = 5
    }
}
