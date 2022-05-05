using Tofu.Payloads;

namespace Tofu.Ledger
{
    public class Blockchain
    {
        /// <summary>
        /// The chain of blocks.
        /// </summary>
        public List<Block> Chain { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blockchain"/> class.
        /// </summary>
        public Blockchain()
        {
            Chain = new List<Block>();
        }

        /// <summary>
        /// Adds a block to the chain.
        /// </summary>
        /// <param name="block">The block to add.</param>
        public void AddBlock(Block block)
        {
            // TODO: Verify the block is valid
            // Add the block to the chain.
            Chain.Add(block);
        }
    }
}