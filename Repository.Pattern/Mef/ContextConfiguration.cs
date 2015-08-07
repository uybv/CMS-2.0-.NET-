using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Repository.Pattern.Mef
{
    public class ContextConfiguration
    {
        [ImportMany(typeof(IEntityConfiguration))]
        public IEnumerable<IEntityConfiguration> Configurations { get; set; }
    }
}
