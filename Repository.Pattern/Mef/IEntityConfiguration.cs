using System.Data.Entity.ModelConfiguration.Configuration;

namespace Repository.Pattern.Mef
{
    public interface IEntityConfiguration
    {
        void AddConfiguration(ConfigurationRegistrar registrar);
    }
}
