using System;

using Tofu.Cryptography;
using Tofu.Ledger;
using Tofu.Payloads;

namespace Tofu
{
    public class TofuSystem
    {
        /// <summary>
        /// Settings for the Tofu system
        /// </summary>
        public static ProtocolSettings? Settings { get; }

        /// <summary>
        /// The blockchain instance.
        /// </summary>
        public static Blockchain Blockchain { get; } = new Blockchain();

        public TofuSystem(ProtocolSettings settings)
        {
            //Settings = settings;
        }
    }
}