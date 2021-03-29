using System.Collections.Generic;

namespace RookieShop.BackEnd.Data.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; private set; }
    }
}
