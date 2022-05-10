using System;

using Tofu.Cryptography;
using Tofu.Ledger;
using Tofu.Payloads;

namespace Tofu
{
    public class TofuSystem
    {
        /// <summary>
        /// Protocol settings for the <see cref="TofuSystem"/>.
        /// </summary>
        public ProtocolSettings Settings { get; init; }

        /// <summary>
        /// The blockchain instance.
        /// </summary>
        public Blockchain Blockchain { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TofuSystem"/> class.
        /// </summary>
        /// <param name="settings">The protocol settings.</param>
        public TofuSystem(ProtocolSettings settings)
        {
            Settings = settings;
            Blockchain = new Blockchain(settings);
        }
    }
}