using Tofu.Cryptography;

namespace Tofu.Payloads
{
    public class Block
    {
        /// <summary>
        // The index of the block
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// The transactions in the block
        /// </summary>
        public List<Transaction> Transactions { get; set; }
        
        /// <summary>
        /// The version of the block
        /// The version represents what part of blockchain the block is part of.
        /// 
        /// 0 => Genesis block
        /// 1 => Main chain
        /// 2 => Smart contracts
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// The hash of the previous block
        /// </summary>
        public string PrevHash { get; set; }

        /// <summary>
        /// The random nonce added to the block
        /// </summary>
        public int Nonce { get; set; }

        /// <summary>
        /// The timestamp when the block was created
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The merkle root of the transactions
        /// </summary>
        public string MerkleRoot { get; set; }

        public Block(
            int Index,
            List<Transaction> Transactions,
            int Version,
            string PrevHash
        )
        {
            this.Index = Index;
            this.Transactions = Transactions;
            this.Version = Version;
            this.PrevHash = PrevHash;

            // Set timestamp
            this.Timestamp = DateTime.UtcNow;

            // Get list of transaction hashes
            List<string> transactionHashes = new List<string>();
            foreach (Transaction transaction in Transactions)
            {
                transactionHashes.Add(Crypto.ToHex(Crypto.SHA256Hash(transaction.ToString())));
            }

            // Calculate the merkle root
            this.MerkleRoot = MerkleTree.CalculateMerkleRoot(transactionHashes);
        }

        /// <summary>
        /// Return the <see cref="Block"> as a string
        /// </summary>
        /// <returns>The block as a string</returns>
        public override string ToString()
        {
            return $"{Index} {Version} {PrevHash} {Nonce} {Timestamp} {MerkleRoot}";
        }

        ///<summary>
        /// Hash the block
        ///</summary>
        ///<returns>The hash of the block</returns>
        public string Hash()
        {
            var hash = Crypto.ToHex(Crypto.SHA256Hash(ToString()));
            return hash;
        }
    }
}