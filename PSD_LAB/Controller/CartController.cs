using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Controller
{
    public class CartController
    {
        CartHandler CH = new CartHandler();
        public int AddCart(int userid, int makeupid, int quantity)
        {
            if (quantity > 0)
            {
                CH.AddCart(userid, makeupid, quantity);
                return 1;
            }
            return 0;
        }
        public List<Cart> GetCartsByUserID(int userID)
        {
            return CH.GetCartsByUserID(userID);
        }

        public void ClearCart(int userid)
        {
            CH.ClearCart(userid);
        }
    }
}