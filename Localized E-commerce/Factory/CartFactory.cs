using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Factory
{
    public class CartFactory
    {
        public static Cart AddToCart(int userId, int productId, int quantity, String size)
        {
            Cart cart = new Cart()
            {
                userId = userId,
                productId = productId,
                quantity = quantity,
                size = size
            };

            return cart;
        }
    }
}