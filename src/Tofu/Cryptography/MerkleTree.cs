namespace Tofu.Cryptography
{
    public class MerkleTree
    {
        /// <summary>
        /// Calculates the Merkle root of a list of hashes.
        /// </summary>
        /// <param name="hashes">The list of hashes.</param>
        /// <returns>The Merkle root.</returns>
        public static string CalculateMerkleRoot(List<string> hashes)
        {
            if (hashes.Count == 0)
            {
                return "";
            }

            if (hashes.Count == 1)
            {
                return hashes[0];
            }

            List<string> newHashes = new List<string>();
            for (int i = 0; i < hashes.Count; i += 2)
            {
                if (i + 1 == hashes.Count)
                {
                    newHashes.Add(hashes[i]);
                }
                else
                {
                    newHashes.Add(Sha256.SHA256(string.Concat(hashes[i], hashes[i + 1])));
                }
            }

            return CalculateMerkleRoot(newHashes);
        }
    }
}