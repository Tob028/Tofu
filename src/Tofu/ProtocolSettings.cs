using System;
using System.Json;
using System.IO;

namespace Tofu
{
    public class ProtocolSettings
    {
        /// <summary>
        /// The maximum number of transactions that can be in the transaction pool
        /// </summary>
        public int TransactionPoolCapacity { get; init; }

        /// <summary>
        /// Initializer for the protocol settings
        /// </summary>
        public ProtocolSettings()
        {
            TransactionPoolCapacity = 2;
        }

        /// <summary>
        /// Load settings from a JSON file
        /// </summary>
        /// <param name="filePath">Path to the JSON file</param>
        /// <returns>The loaded settings</returns>
        public static ProtocolSettings LoadFromFile(string filePath)
        {
            return JsonConvert.DeserializeObject<ProtocolSettings>(File.ReadAllText(filePath));
        }
    }
}