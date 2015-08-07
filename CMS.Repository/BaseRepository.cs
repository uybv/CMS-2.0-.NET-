using System.Collections.Generic;
using System.Linq;
using Repository.Pattern.Repositories;
using CMS.Entities;
using CMS.Entities.Models;
using Repository.Pattern.Ef;

namespace CMS.Repository
{
    public static class BaseRepository
    {
        public static IEnumerable<Entity> GetAll(this IRepositoryAsync<Entity> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
    }
}
