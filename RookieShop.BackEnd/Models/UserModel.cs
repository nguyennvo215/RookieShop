using Microsoft.AspNetCore.Identity;

namespace RookieShop.BackEnd.Models
{
    public class UserModel : IdentityUser
    {
        public UserModel() : base()
        {
        }

        public UserModel(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }
    }
}
