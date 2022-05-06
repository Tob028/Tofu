namespace Tofu.Network
{
    public class Peer
    {
        /// <summary>
        /// The IP address of the peer
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// The destination port of the peer
        /// </summary>
        public int DestinationPort { get; set; }

        /// <summary>
        /// The source port of the peer
        /// </summary>
        public int SourcePort { get; set; }

        /// <summary>
        /// If the peer is trusted
        /// Trusted peer is always connected
        /// </summary>
        public bool Trusted { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Peer"/> class.
        /// </summary>
        public Peer(string ip, int destinationPort, int sourcePort, bool trusted)
        {
            IpAddress = ip;
            DestinationPort = destinationPort;
            SourcePort = sourcePort;
            Trusted = trusted;
        }
    }
}