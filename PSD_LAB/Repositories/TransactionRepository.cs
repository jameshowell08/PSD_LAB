using PSD_LAB.Factory;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PSD_LAB.Repositories
{
    public class TransactionRepository
    {
        public Database1Entities db = DatabaseSingleton.GetInstance();
        TransactionFactory TF = new TransactionFactory();

        public int GenerateID()
        {
            return GetLastID() + 1;
        }
        public int GetLastID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }

        public TransactionHeader AddTransactionHeader(int userid, DateTime transactiondate)
        {
            TransactionHeader th = TF.CreateTrHeader(GenerateID(), userid, transactiondate, "unhandled");
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return th;
        }
        public void AddTransactionDetail(int transactionid, int makeupid, int quantity)
        {
            TransactionDetail td = TF.CreateTrDetail(transactionid, makeupid, quantity);
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

        public List<TransactionHeader> GetAllTrHeaderByID(int userid)
        {
            return db.TransactionHeaders.Where(x => x.UserID == userid).ToList();
        }
        public List<TransactionHeader> GetAllTrHeaderDone()
        {
            return db.TransactionHeaders.Where(x => x.Status == "handled").ToList();
        }
        public List<TransactionHeader> GetAllTrHeader()
        {
            return db.TransactionHeaders.ToList();
        }

        public List<TransactionDetail> GetTrDetailByID(int transactionid)
        {
            return db.TransactionDetails.Where(x => x.TransactionID == transactionid).ToList();
        }

        public void UpdateStatus(int transactionid)
        {
            TransactionHeader th = db.TransactionHeaders.Find(transactionid);
            th.Status = "Handled";
            db.SaveChanges();
        }
    }
}