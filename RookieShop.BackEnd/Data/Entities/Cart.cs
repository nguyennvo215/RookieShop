using System;
using System.Collections.Generic;

namespace RookieShop.BackEnd.Data.Entities
{
    public class Cart : BaseEntity
    {
        public Cart()
        {
            Products = new HashSet<Product>();
        }
        public int UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime AddedDate { get; set; }
        public bool isCheckedOut { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
