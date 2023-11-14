using System;
using ShopOnline.Models.Dtos;
using System.Net.Http.Json;
using ShopOnline.WebApplication.Services.Contracts;

namespace ShopOnline.WebApplication.Services
{
	public class ProductService: IProductService
	{
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
        }
    }
}

