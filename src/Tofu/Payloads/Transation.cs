namespace Tofu.Payloads
{
    public class Transaction
    {
        /// <summary>
        /// The transaction hash used for calculating Merkle Tree
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// The id of the transaction
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Public key of the recipient
        /// </summary>
        public string Recipient { get; set; }

        /// <summary>
        /// Public key of the sender
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// The amount sent
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Network fee
        /// </summary>
        public int Fee { get; set; }
    }
}