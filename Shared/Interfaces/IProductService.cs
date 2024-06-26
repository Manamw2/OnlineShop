using Shared.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task AddProductAsync(CreateProductDto productDto);
        Task<ProductDto?> GetProductByIdAsync(int productId);
    }
}
