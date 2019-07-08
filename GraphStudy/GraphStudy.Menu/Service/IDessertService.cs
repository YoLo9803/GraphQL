using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public interface IDessertService
    {
        /// <summary>
        /// 按照編號取得點心
        /// </summary>
        /// <param name="id"></param>
        Dessert GetDessertById(int id);
    }
}
