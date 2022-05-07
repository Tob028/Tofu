using System.Text.Json;

using Tofu.Network;

namespace Tofu.Persistence
{
    public class ManagePeers
    {
        /// <summary>
        /// The list of peers
        /// </summary>
        public List<Peer> Peers { get; set; }

        /// <summary>
        /// Path to the file containing the list of peers
        /// </summary>
        public string PeerFilePath { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePeers"/> class.
        /// </summary>
        public ManagePeers()
        {
            Peers = new List<Peer>();
            PeerFilePath = "Storage/Peers.json";

            ReadPeers();
        }

        /// <summary>
        /// Adds a peer to the list of peers.
        /// </summary>
        /// <param name="peer">The peer to add.</param>
        public void AddPeer(Peer peer)
        {
            Peers.Add(peer);
            WritePeers();
        }

        /// <summary>
        /// Writes the list of peers to the file.
        /// </summary>
        private void WritePeers()
        {
            File.WriteAllText(PeerFilePath, JsonSerializer.Serialize(Peers));
        }

        /// <summary>
        /// Reads the peers from the file.
        /// </summary>
        private void ReadPeers()
        {
            if (File.Exists(PeerFilePath))
            {
                Peers = JsonSerializer.Deserialize<List<Peer>>(File.ReadAllText(PeerFilePath));
            }
        }
    }
}