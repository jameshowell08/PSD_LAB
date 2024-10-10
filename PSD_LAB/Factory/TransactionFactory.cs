using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB.Factory
{
    public class TransactionFactory
    {
        public TransactionHeader CreateTrHeader(int transactionid, int userid, DateTime transactiondate, string status)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = transactionid;
            th.UserID = userid;
            th.TransactionDate = transactiondate;
            th.Status = status;
            return th;

        }

        public TransactionDetail CreateTrDetail(int transactionID, int makeupid, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = transactionID;
            td.MakeupID = makeupid;
            td.Quantity = quantity;
            return td;
        }

    }
}