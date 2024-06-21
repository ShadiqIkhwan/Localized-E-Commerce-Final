using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Repository
{
    public class CartRepository
    {

        public static LocalizedDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static void AddToCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static Object getCartByUserId(int userId)
        {
            var carts = (from c in db.Carts
                         join p in db.Products on c.productId equals p.Id
                         select new
                         {
                             Id = c.Id,
                             productId = p.Id,
                             name = p.name,
                             quantity = c.quantity,
                             mainImage = p.mainImage,
                             price = p.price * c.quantity,
                             size = c.size
                         }
                         );
            return carts.ToList();
        }

        public static void DeleteCartByID(int id)
        {
            Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}