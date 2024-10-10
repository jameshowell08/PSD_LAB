using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class CartFactory
    {
        public Cart createCart(int cartid, int userid, int makeupid, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartid;
            cart.UserID = userid;
            cart.MakeupID = makeupid;
            cart.Quantity = quantity;
            return cart;
        }
    }
}