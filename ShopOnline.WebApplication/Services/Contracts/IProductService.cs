using System;
using ShopOnline.Models.Dtos;

namespace ShopOnline.WebApplication.Services.Contracts
{
	public interface IProductService
	{
        Task<IEnumerable<ProductDto>> GetItems();
        

    }
}

