namespace Tofu.Payloads
{
    /// <summary>
    /// Class representing a transaction on the blockchain.
    public class Transaction
    {
        /// <summary>
        /// Public key of the sender
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Public key of the recipient
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// The amount sent
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Network fee
        /// </summary>
        public int Fee { get; set; }
        
        /// <summary>
        /// Timestamp of the transaction
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction"/> class.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="recipient">Recipient.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="fee">Fee.</param>
        public Transaction(string sender, string recipient, int amount, int fee)
        {
            Sender = sender;
            Recipient = recipient;
            Amount = amount;
            Fee = fee;
            Timestamp = DateTime.UtcNow;
        }

        /// <summary>
        /// Returns the <see cref="Transaction"/> as a string.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            return $"{Sender} -> {Recipient} ({Amount} + {Fee})";
        }
    }
}