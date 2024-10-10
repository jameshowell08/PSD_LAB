using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSD_LAB.Controller
{
    public class TransactionController
    {
        TransactionHandler TH = new TransactionHandler();
        public string AddTransactionHeader(int userid)
        {
            TH.AddTransactionHeader(userid, DateTime.Now);
            return "checkout success";
        }
        public void AddTransactionDetail(int transactionid, int makeupid, int quantity)
        {
            TH.AddTransactionDetail(transactionid, makeupid, quantity);
        }

        public List<TransactionHeader> GetAllTrHeaderByID(int userid)
        {
            return TH.GetAllTrHeaderByID(userid);
        }
        public List<TransactionHeader> GetAllTrHeader()
        {
            return TH.GetAllTrHeader();
        }

        public List<TransactionDetail> GetTrDetailByID(int transactionid)
        {
            return TH.GetTrDetailByID(transactionid);
        }
        public List<TransactionHeader> GetAllTrHeaderDone()
        {
            return TH.GetAllTrHeaderDone();
        }
        public void UpdateStatus(int transactionid)
        {
            TH.UpdateStatus(transactionid);
        }

    }
}