using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    
    public class CartRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        CartFactory CF = new CartFactory();

        public void AddCart(int userid, int makeupid, int quantity)
        {
            Cart cart = CF.createCart(GenerateID(), userid, makeupid, quantity);  
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        public List<Cart> GetCartsByUserID(int userID)
        {
            return db.Carts.Where(x => x.UserID == userID).ToList();   
        }

        public void ClearCart(int userid)
        {
            db.Carts.RemoveRange(db.Carts.Where(x => x.UserID == userid));
            db.SaveChanges();
        }
       


    }
}