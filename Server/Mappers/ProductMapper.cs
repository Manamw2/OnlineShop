using Server.Models;
using Shared.Dtos.Product;
namespace Server.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ProductToProductDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                CategoryName = product.Category!=null? product.Category.Name : ""
            };
        }
        public static Product CreateProductDtoToProduct(this CreateProductDto productDto)
        {
            return new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId,
            };
        }
    }
}
