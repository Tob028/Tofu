using Tofu.Payloads;

namespace Tofu.Ledger
{
    class CreateGenesisBlock
    {
        /// <summary>
        /// Creates a genesis block
        /// </summary>
        /// <returns>The genesis block</returns>
        public static Block Create()
        {
            var header = new BlockHeader("", 0, DateTime.UtcNow, "", 0);

            return new Block(header, new List<Transaction>());
        }
    }
}