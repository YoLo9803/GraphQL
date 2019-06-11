using System;

namespace GraphStudy.Movies.Movies
{
    //新增類的模板
    public class MovieInput
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }//上映時間
        public string Company { get; set; }
        public int ActorId { get; set; }//演員ID
        public MovieRating MovieRating { get; set; }//電影等級列舉
    }
}