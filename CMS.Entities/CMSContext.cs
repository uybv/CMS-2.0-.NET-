using System.Data.Entity;
using Repository.Pattern.Ef;
using CMS.Entities.Models.Mapping;

namespace CMS.Entities
{
    public class CMSContext : DataContext
    {
        static CMSContext()
        {
            Database.SetInitializer<CMSContext>(null);
        }

        public CMSContext() : base("Name=CMS", typeof(IMap).Assembly)
        {
        }

        public new IDbSet<T> Set<T>() where T : Entity
        {
            return base.Set<T>();
        }
    }
}
