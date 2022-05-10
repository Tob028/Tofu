using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tofu
{
    public class ProtocolSettings
    {
        /// <summary>
        /// The maximum number of transactions that can be in the transaction pool
        /// </summary>
        public int TransactionPoolCapacity { get; init; }

        /// <summary>
        /// The minimum number of zeros in the nonce.
        /// </summary>
        public int NonceLength { get; init; }

        

        /// <summary>
        /// Initializer for the protocol settings
        /// </summary>
        public ProtocolSettings()
        {
            TransactionPoolCapacity = 5;
            NonceLength = 4;
        }

        /// <summary>
        /// Load settings from a JSON file
        /// </summary>
        /// <param name="filePath">Path to the JSON file</param>
        /// <returns>The loaded settings</returns>
        public static ProtocolSettings LoadFromFile(string filePath)
        {
            var settings = JsonSerializer.Deserialize<ProtocolSettings>(File.ReadAllText(filePath));
            return settings != null ? settings : new ProtocolSettings();
        }
    }
}