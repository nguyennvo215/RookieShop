using System;

namespace RookieShop.BackEnd.Data.Entities
{
    public class Product : BaseEntity
    {
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductFullDescription { get; set; }
        public double ProductPrice { get; set; }
        public double PromotionPrice { get; set; }
        public string Image { get; set; }
        public bool isPublished { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
