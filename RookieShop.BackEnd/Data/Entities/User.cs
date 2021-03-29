using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RookieShop.BackEnd.Data.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserRoles = new HashSet<UserInRole>();
        }
        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(60, MinimumLength = 6)]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserInRole> UserRoles { get; set; }
    }
}
