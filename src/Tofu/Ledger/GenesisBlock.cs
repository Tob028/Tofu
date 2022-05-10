using Tofu.Payloads;

namespace Tofu.Ledger
{
    class GenesisBlock
    {
        /// <summary>
        /// Creates a genesis block
        /// </summary>
        /// <returns>The genesis block</returns>
        public static Block Create()
        {
            return new Block(0, new List<Transaction>(), 0, "genesis block");
        }
    }
}