using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
   
    public class CartHandler
    {
        CartRepository CR = new CartRepository();

        public void AddCart(int userid, int makeupid, int quantity)
        {
            CR.AddCart(userid, makeupid, quantity);
        }
        public List<Cart> GetCartsByUserID(int userID)
        {
            return CR.GetCartsByUserID(userID);
        }

        public void ClearCart(int userid)
        {
            CR.ClearCart(userid);
        }
    }
}