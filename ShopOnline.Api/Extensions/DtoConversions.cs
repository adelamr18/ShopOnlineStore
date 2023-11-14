using System;
using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Extensions
{
	public static class DtoConversions
	{
		public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories )
		{
			return (from product in products
					join productCategorie in productCategories
					on product.CategoryId equals productCategorie.Id
					select new ProductDto
					{
						Id = product.Id,
						Name = product.Name,
						Description = product.Description,
						ImageURL = product.ImageURL,
						Price = product.Price,
						Qty = product.Qty,
						CategoryId = product.CategoryId,
						CategoryName = productCategorie.Name
					}).ToList();
		}
	}
}

