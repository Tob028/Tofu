using Tofu;
using Tofu.Payloads;
using Tofu.Cryptography;

namespace Tofu.Ledger
{
    /// <summary>
    /// Responsible for managing the blockchain.
    /// </summary>
    public class Blockchain
    {
        /// <summary>
        /// The chain of blocks.
        /// </summary>
        public List<Block> Chain { get; set; }

        /// <summary>
        /// Protocol settings for the <see cref="Blockchain"/>.
        /// </summary>
        public ProtocolSettings Settings { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blockchain"/> class.
        /// </summary>
        /// <param name="settings">The protocol settings.</param>
        public Blockchain(ProtocolSettings settings)
        {
            Settings = settings;
            Chain = new List<Block>();
        }

        /// <summary>
        /// Adds a validated block to the chain.
        /// </summary>
        /// <param name="block">The block to add.</param>
        public void AddBlock(Block block)
        {
            // Verify the nonce is correct.
            if (block.Hash().Substring(0, Settings.NonceLength) != new string('0', Settings.NonceLength))
            {
                Console.WriteLine($"Invalid block #{block.Index} nonce: {block.Nonce}");
                return;
            }

            // Add the block to the chain.
            Chain.Add(block);
        }
    }
}