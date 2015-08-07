using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Repository.Pattern.Mef;

namespace Repository.Pattern.Ef.Mef
{
    public class EntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity>, IEntityConfiguration where TEntity : Entity, new()
    {
        public string Schema { get; set; }

        public EntityConfiguration(string tableName = null)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = typeof(TEntity).Name;
            }
            ToTable(tableName);
        }

        public virtual void AddConfiguration(ConfigurationRegistrar registrar)
        {
            registrar.Add(this);
        }
    }
}
