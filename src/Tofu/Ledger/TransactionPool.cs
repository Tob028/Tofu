using System;

using Tofu;
using Tofu.Payloads;
using Tofu.Cryptography;

namespace Tofu.Ledger
{
    /// <summary>
    /// Responsible for storing transactions until added to new block.
    public class TransactionPool
    {
        /// <summary>
        /// List of transactions waiting to be added to the blockchain
        /// </summary>
        List<Transaction> TxPool = new List<Transaction>();

        /// <summary>
        /// Capacity of the transaction pool
        /// </summary>
        //int TransactionPoolCapacity => TofuSystem.Settings.TxPoolCapacity;

        /// <summary>
        // Add transaction to the transaction pool
        /// </summary>
        /// <param name="transaction">Transaction to add</param>
        public void AddTransaction(Transaction transaction)
        {
            TxPool.Add(transaction);
        }
    }
}