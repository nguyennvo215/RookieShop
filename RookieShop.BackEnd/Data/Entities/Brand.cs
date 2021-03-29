using System.Collections.Generic;

namespace RookieShop.BackEnd.Data.Entities
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public string BrandName { get; set; }
        public virtual ICollection<Product> Products { get; private set; }
    }
}
