using System;

using Tofu;
using Tofu.Payloads;
using Tofu.Cryptography;

namespace Tofu.Ledger
{
    public class TransactionPool
    {
        /// <summary>
        /// List of transactions waiting to be added to the blockchain
        /// </summary>
        List<Transaction> TransactionPool = new List<Transaction>();

        /// <summary>
        /// Capacity of the transaction pool
        /// </summary>
        int TransactionPoolCapacity => TofuSystem.Settings.TransactionPoolCapacity;

        /// <summary>
        // Add transaction to the transaction pool
        /// </summary>
        /// <param name="transaction">Transaction to add</param>
        public void AddTransaction(Transaction transaction)
        {
            TransactionPool.Add(transaction);
        }
    }
}