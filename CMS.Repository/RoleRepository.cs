using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Repository.Pattern.Repositories;
using CMS.Entities;
using CMS.Entities.Models;
using Repository.Pattern.Ef;


namespace CMS.Repository
{
    public static class RoleRepository
    {
        public static IEnumerable<Role> GetByStatus(this IRepositoryAsync<Role> repository, Status status = Status.Enable)
        {
            return repository.Query(e => e.Status == status)
                .Select();
        }

        public static IEnumerable<Role> GetByPage(this IRepositoryAsync<Role> repository,
            out int totalCount,
            Expression<Func<Role, bool>> filter = null,
            Func<IQueryable<Role>, IOrderedQueryable<Role>> orderBy = null,
            int page = 1,
            int pageSize = 25)
        {
            return repository.Query(filter)
                .OrderBy(orderBy)
                .SelectPage(page, pageSize, out totalCount);

        }

        public static IEnumerable<Role> GetAll(this IRepositoryAsync<Role> repository, Func<IQueryable<Role>, IOrderedQueryable<Role>> orderBy = null)
        {
            return repository.Query()
                .OrderBy(orderBy)
                .Select();
        }
    }
}
