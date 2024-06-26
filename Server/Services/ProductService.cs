using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Mappers;
using Shared.Dtos.Product;
using Shared.Interfaces;

namespace Server.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(CreateProductDto productDto)
        {
            await _context.AddAsync(productDto.CreateProductDtoToProduct());
            await _context.SaveChangesAsync();
        }

        public async Task<ProductDto?> GetProductByIdAsync(int productId)
        {
            var product =  await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            return product==null? null:product.ProductToProductDto();
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products =  await _context.Products.Include(u => u.Category).ToListAsync();
            return products.Select(u => u.ProductToProductDto());
        }
    }
}
