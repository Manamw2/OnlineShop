using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Shared.Dtos.Product;
using Shared.Interfaces;

namespace Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;

        public ProductService(HttpClient httpClient, IJSRuntime jSRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jSRuntime;
        }
        public async Task AddProductAsync(CreateProductDto productDto)
        {
            var token = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "token");

            if (string.IsNullOrEmpty(token))
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            await _httpClient.PostAsJsonAsync("api/Product", productDto);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int productId)
        {
            return await _httpClient.GetFromJsonAsync<ProductDto>($"api/Product/{productId}");
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products =  await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
            return products!=null? products:[];
        }
    }
}