namespace Tofu.Cryptography
{
    public class Sha256
    {
        /// <summary>
        /// Calculates the SHA256 hash of a string.
        /// </summary>
        /// <param name="input">The string to hash.</param>
        /// <returns>The SHA256 hex digest of the string.</returns>
        public static string SHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Calculates the SHA256 hash of a string and returns in bin.
        /// </summary>
        /// <param name="input">The string to hash.</param>
        /// <returns>The SHA256 digest of the string.</returns>
        public static byte[] SHA256Bin(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert byte array to a string   
                return bytes;
            }
        }
    }
}