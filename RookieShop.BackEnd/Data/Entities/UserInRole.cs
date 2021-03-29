namespace RookieShop.BackEnd.Data.Entities
{
    public class UserInRole
    {
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
