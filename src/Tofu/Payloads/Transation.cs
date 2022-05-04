namespace Tofu.Payloads
{
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
        public string Timestamp { get; set; }
    }
}