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
        public static ProtocolSettings Settings { get; }

        public TofuSystem(ProtocolSettings settings)
        {
            Settings = settings;
        }
    }
}