using System;

using Tofu;
using Tofu.Cryptography;
using Tofu.Payloads;

namespace Tofu.Ledger
{
    /// <summary>
    /// Responsible for storing transactions until added to new block.
    public class TransactionPool
    {
        /// <summary>
        /// List of transactions waiting to be added to the blockchain
        /// </summary>
        readonly List<Transaction> Pool = new List<Transaction>();

        /// <summary>
        /// Capacity of the transaction pool
        /// </summary>
        int TransactionPoolCapacity => Settings.TransactionPoolCapacity;

        /// <summary>
        /// The protocol settings for the <see cref="TransactionPool"/>.
        /// </summary>
        ProtocolSettings Settings { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPool"/> class.
        /// </summary>
        /// <param name="settings">The protocol settings.</param>
        public TransactionPool(ProtocolSettings settings)
        {
            Settings = settings;
        }

        /// <summary>
        // Add transaction to the transaction pool
        /// </summary>
        /// <param name="transaction">Transaction to add</param>
        public void AddTransaction(Transaction transaction)
        {
            Pool.Add(transaction);
        }
    }
}