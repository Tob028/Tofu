namespace Tofu.Payloads
{
    class Block
    {
        /// <summary>
        /// The hash of the block
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        // The index of the block
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// The header of the block
        /// </summary>
        public BlockHeader Header { get; set; }

        /// <summary>
        /// The transactions in the block
        /// </summary>
        public List<Transaction> Transactions { get; set; }
        
        public string Version => Header.Version;
        public string PrevHash => Header.PrevHash;
        public int Nonce => Header.Nonce;
        public string Timestamp => Header.Timestamp;
        public string MerkleRoot => Header.MerkleRoot;
    }
}