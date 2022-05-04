namespace Tofu.Payloads
{
    public class BlockHeader
    {
        /// <summary>
        /// The version of the block
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The hash of the previous block
        /// </summary>
        public string PrevHash { get; set; }

        /// <summary>
        /// Nonce used for creation of the block
        /// </summary>
        public int Nonce { get; set; }

        /// <summary>
        /// The timestamp of the block
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// The merkle root of the block
        /// </summary>
        public string MerkleRoot { get; set; }

        public BlockHeader(string prevHash, string version, string timestamp, string merkleRoot, int nonce)
        {
            PrevHash = prevHash;
            Version = version;
            Timestamp = timestamp;
            MerkleRoot = merkleRoot;
            Nonce = nonce;
        }
    }
}