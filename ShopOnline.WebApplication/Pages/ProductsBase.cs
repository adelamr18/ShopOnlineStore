using System;
using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.WebApplication.Services.Contracts;

namespace ShopOnline.WebApplication.Pages
{
	public class ProductsBase: ComponentBase
	{
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {

            Products = await ProductService.GetItems();
        }
    }
}

