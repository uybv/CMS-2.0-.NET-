using System;
using Repository.Pattern.Ef;

namespace CMS.Entities.Models
{
    public class Role : Entity
    {
        public Role()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
