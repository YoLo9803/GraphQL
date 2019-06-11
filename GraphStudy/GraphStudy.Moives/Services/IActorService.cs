using GraphStudy.Movies.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphStudy.Movies.Services
{
    public interface IActorService
    {
        Task<Actor> GetByIdAsync(int id);//獲取某個演員資訊
        Task<IEnumerable<Actor>> GetAsync();//獲取所有演員資訊
    }
}