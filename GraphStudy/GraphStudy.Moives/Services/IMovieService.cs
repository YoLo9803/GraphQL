using GraphStudy.Movies.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphStudy.Movies.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAsyncs();//獲取所有列
        Task<Movie> GetByIdAsync(int id);//獲取某個對應id屬性的列
        Task<Movie> CreateAsync(Movie movie);//建立
    }
}