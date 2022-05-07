using System.Security.Cryptography;
using System.Text;

namespace Tofu.Cryptography
{
    /// <summary>
    /// Provides cryptographic functions.
    /// </summary>
    public static class Crypto
    {
        /// <summary>
        /// Calculates the SHA256 hash of a string.
        /// </summary>
        /// <param name="input">The string to hash.</param>
        /// <returns>The SHA256 digest of the string.</returns>
        public static byte[] SHA256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        /// <summary>
        /// Turn a byte array into a hexadecimal string.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>The hexadecimal string.</returns>
        public static string ToHex(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Turn a hexadecimal string into a byte array.
        /// </summary>
        /// <param name="hex">The hexadecimal string to convert.</param>
        /// <returns>The byte array.</returns>
        public static byte[] ToBytes(string hex)
        {
            var bytes = new byte[hex.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// Generate public and private keys.
        /// </summary>
        /// <returns>The generated keys.</returns>
        public static KeyPair GenerateKeys()
        {
            var rsa = new RSACryptoServiceProvider(2048);
            var publicKey = rsa.ExportParameters(false);
            var privateKey = rsa.ExportParameters(true);
            return new KeyPair(publicKey, privateKey);
        }

        /// <summary>
        /// Signs a message with the given private key using RSA.
        /// </summary>
        /// <param name="message">The message to sign.</param>
        /// <param name="privateKey">The private key to sign with.</param>
        /// <returns>The signature of the message as a string.</returns>
        public static string Sign(string message, RSAParameters privateKey)
        {
            var rsa = new RSACryptoServiceProvider(2048);
            rsa.ImportParameters(privateKey);
            var bytes = rsa.SignData(Encoding.UTF8.GetBytes(message), "SHA256");
            return ToHex(bytes);
        }

        /// <summary>
        /// Verifies a signature with the given public key using RSA.
        /// </summary>
        /// <param name="message">The message to verify.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="publicKey">The public key to verify with.</param>
        /// <returns>True if the signature is valid, false otherwise.</returns>
        public static bool Verify(string message, string signature, RSAParameters publicKey)
        {
            var rsa = new RSACryptoServiceProvider(2048);
            rsa.ImportParameters(publicKey);
            var bytes = rsa.VerifyData(Encoding.UTF8.GetBytes(message), "SHA256", ToBytes(signature));
            return bytes;
        }
    }
}