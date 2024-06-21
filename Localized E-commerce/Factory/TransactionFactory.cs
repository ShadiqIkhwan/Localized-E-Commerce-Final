using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Factory
{
    public class TransactionFactory
    {
        public static Transaction AddToTransaction(int userId)
        {
            Transaction transaction = new Transaction()
            {
                userId = userId,
                Status = "Process",
                TransactionDate = DateTime.Now,
            };

            return transaction;
        }

        public static TransactionDetail AddToTransactionDetail(int transactionId, int productId, int quantity, String size)
        {
            TransactionDetail transactionDetail = new TransactionDetail()
            {
                transactionId = transactionId,
                productId = productId,
                Quantity = quantity,
                size = size
            };

            return transactionDetail;
        }
    }
}