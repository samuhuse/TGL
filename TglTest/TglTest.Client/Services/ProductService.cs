using System.Net.Http.Json;
using TglTest.Client.Models;

namespace TglTest.Client.Services
{
    public class ProductService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<ApiProductResponse> GetProductsAsync(int limit = 10, int skip = 0)
        {
            var response = await _httpClient.GetFromJsonAsync<ApiProductResponse>($"https://dummyjson.com/products?limit={limit}&skip={skip}");

            return response ?? throw new Exception("Failed to fetch products");
        }

        public async Task<Product> GetProductAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Product>($"https://dummyjson.com/products/{id}");

            return response ?? throw new Exception("Failed to fetch product");
        }
    }
}
