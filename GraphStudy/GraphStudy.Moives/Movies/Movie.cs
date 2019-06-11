using GraphStudy.Movies.Movies;
using System;

namespace GraphStudy.Movies.Movies
{
    //電影類
    public class Movie
    {
        public int Id { get; set; }//電影編號
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }//上映時間
        public string Company { get; set; }
        public int ActorId { get; set; }//演員ID
        public MovieRating MovieRating { get; set; }//電影等級列舉
    }
}