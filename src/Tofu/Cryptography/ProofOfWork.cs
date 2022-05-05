using Tofu.Payloads;

namespace Tofu.Cryptography
{
    public class ProofOfWork
    {
        /// <summary>
        /// The proof of work algorithm.
        /// </summary>
        /// <param name="block">The payload to be verified.</param>
        /// <returns>The proof of work.</returns>
        public static int Verify(Block block)
        {
            var nonce = 0;
            while (true)
            {
                block.Nonce = nonce;
                var hash = block.Hash();
                
                if (hash.Substring(0, 4) == "0000")
                {
                    return block.Nonce;
                }
            }
        }
    }
}