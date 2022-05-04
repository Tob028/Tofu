using System;
using System.Security.Cryptography;

namespace Tofu.Cryptography
{
    /// <summary>
    /// Represents a pair of public and private keys.
    /// </summary>
    public class KeyPair
    {
        /// <summary>
        /// The private key.
        /// </summary>
        public RSAParameters PrivateKey { get; set; }

        /// <summary>
        /// The public key.
        /// </summary>z
        public RSAParameters PublicKey { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPair"/> class.
        /// </summary>
        /// <param name="publicKey">The public key.</param>
        /// <param name="privateKey">The private key.</param>
        public KeyPair(RSAParameters publicKey, RSAParameters privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }
    }
}