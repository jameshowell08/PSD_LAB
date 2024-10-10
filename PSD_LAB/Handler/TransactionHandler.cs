using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Handler
{
    public class TransactionHandler
    {
        TransactionRepository TR = new TransactionRepository();
        CartRepository CR = new CartRepository();
       
        public void AddTransactionHeader(int userid, DateTime transactiondate)
        {
          
            TransactionHeader th =  TR.AddTransactionHeader(userid, transactiondate);
            List<Cart> carts = CR.GetCartsByUserID(userid);

            foreach (Cart c in carts)
            {
                TR.AddTransactionDetail(th.TransactionID, c.MakeupID, c.Quantity);
            }

            CR.ClearCart(userid);
        }
        public void AddTransactionDetail(int transactionid, int makeupid, int quantity)
        {
            TR.AddTransactionDetail(transactionid, makeupid, quantity); 
        }

        public List<TransactionHeader> GetAllTrHeaderByID(int userid)
        {
            return TR.GetAllTrHeaderByID(userid);
        }
        public List<TransactionHeader> GetAllTrHeader()
        {
            return TR.GetAllTrHeader();
        }

        public List<TransactionDetail> GetTrDetailByID(int transactionid)
        {
            return TR.GetTrDetailByID(transactionid);
        }
        public List<TransactionHeader> GetAllTrHeaderDone()
        {
            return TR.GetAllTrHeaderDone();
        }
        public void UpdateStatus(int transactionid)
        {
            TR.UpdateStatus(transactionid);
        }

    }
}