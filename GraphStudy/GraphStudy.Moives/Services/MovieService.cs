using GraphStudy.Movies.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphStudy.Movies.Services
{
    public class MovieService : IMovieService
    {
        //因為我們需要建立子列表，所以一要用到IList
        private readonly IList<Movie> _movie;

        public MovieService()
        {
            _movie = new List<Movie>
            {
                #region 電影列表
    
                new Movie
                {
                    Id = 1,
                    Name = "肖申克的救贖The Shawshank Redemption",
                    Company = "美國",
                    MovieRating = MovieRating.G,
                    ActorId = 1,
                    ReleaseDate = new DateTime(1994-10-14)
                },
                new Movie
                {
                    Id = 2,
                    Name = "這個殺手不太冷 Léon ",
                    Company = "法國",
                    MovieRating = MovieRating.NC17,
                    ActorId = 2,
                    ReleaseDate = new DateTime(1994-09-14)
                },
                new Movie
                {
                    Id = 3,
                    Name = "三傻大鬧好萊塢",
                    Company = "印度",
                    MovieRating = MovieRating.PG,
                    ActorId = 3,
                    ReleaseDate = new DateTime(2011-12-08)
                },
                new Movie
                {
                    Id = 4,
                    Name = "功夫",
                    Company = "美國",
                    MovieRating = MovieRating.G,
                    ActorId = 4,
                    ReleaseDate = new DateTime(2004-12-23)
                }
                #endregion
            };
        }


        public Task<Movie> CreateAsync(Movie movie)
        {
            _movie.Add(movie);
            return Task.FromResult(movie);
        }

        public Task<IEnumerable<Movie>> GetAsyncs()
        {
            return Task.FromResult(_movie.AsEnumerable());
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            //在這裡需要做個判斷這個id是否存在
            var movie = _movie.SingleOrDefault(x => x.Id == id);
            if (movie == null)
            {
                throw new ArgumentException(String.Format("Movie ID {0} 不正確", id));
            }

            return Task.FromResult(movie);
        }
    }
}