using System.Collections.Generic;

namespace RookieShop.BackEnd.Data.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserInRole>();
        }
        public string RoleName { get; set; }
        public virtual ICollection<UserInRole> UserRoles { get; set; }
    }
}
