using GraphStudy.Movies.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphStudy.Movies.Services
{
    public class ActorService : IActorService
    {
        private readonly IList<Actor> _actor;

        public ActorService()
        {
            _actor=new List<Actor>
            {
                #region 演員列表

                new Actor
                {
                    Id = 1,
                    Name = "肖申克"
                },
                new Actor
                {
                    Id=2,
                    Name = "讓·雷諾"
                },
                new Actor
                {
                    Id = 3,
                    Name = "阿米爾·汗,卡琳娜·卡普爾 ",
                },
                new Actor
                {
                    Id=4,
                    Name = "周星馳,元秋 元華"
                }
                #endregion
            };
        }

        public Task<IEnumerable<Actor>> GetAsync()
        {
            return Task.FromResult(_actor.AsEnumerable());
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            var actor = _actor.SingleOrDefault(x => x.Id == id);
            if (actor == null)
            {
                throw new ArgumentException(String.Format("Actor ID {0} 不存在",id));
            }

            return Task.FromResult(actor);
        }
    }
}