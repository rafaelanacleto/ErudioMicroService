using GeekShopping.Product.API.Model.Base;

namespace GeekShopping.Product.API.Model
{
    public class Product : BaseEntity
    {

        public string? Name { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public string? CategoryName { get; set; }

        public string? ImageURL { get; set; }

        public Product() { }



    }
}
