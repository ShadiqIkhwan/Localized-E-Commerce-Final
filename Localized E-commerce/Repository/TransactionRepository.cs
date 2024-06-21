using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Repository
{
    
    public class TransactionRepository
    {
        public static LocalizedDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static void AddToTransaction(Transaction transaction) {
            Transaction newTransaction = db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public static void AddToTransactionDetail(TransactionDetail transactionDetail) { 
            TransactionDetail newTransactionDetail = db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }

        public static List<Transaction> GetAllHistory(int userId)
        {
            return db.Transactions.Where(x => x.userId == userId).ToList();
        }
    }
}