﻿using System;
namespace ShopOnline.Models.Dtos
{
	public class CartItemToAdd
	{
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}
