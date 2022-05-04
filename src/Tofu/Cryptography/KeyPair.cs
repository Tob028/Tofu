using System;
using System.Security.Cryptography;

namespace Tofu.Cryptography
{
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
    }
}