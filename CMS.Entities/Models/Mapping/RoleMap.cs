using System.ComponentModel.Composition;
using Repository.Pattern.Mef;
using Repository.Pattern.Ef.Mef;

namespace CMS.Entities.Models.Mapping
{
    [Export(typeof(IEntityConfiguration))]
    public class RoleMap : EntityConfiguration<Role>
    {
        [ImportingConstructor]
        public RoleMap() : base()
        {
            HasKey(t => t.Id);
            Property(t => t.Name)
                .IsRequired();
        }

    }
}
