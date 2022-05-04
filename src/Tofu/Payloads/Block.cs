namespace Tofu.Payloads
{
    public class Block
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

        public Block(int index, string prevHash, string version, string timestamp, string merkleRoot, int nonce)
        {
            Index = index;
            Header = new BlockHeader(prevHash, version, timestamp, merkleRoot, nonce);
            Transactions = new List<Transaction>();
        }
    }
}