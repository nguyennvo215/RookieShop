using System;

namespace RookieShop.BackEnd.Data.Entities
{
    public class RetailDetail : BaseEntity
    {
        public int CartID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime AddedDate { get; set; }
        public bool isPaid { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
