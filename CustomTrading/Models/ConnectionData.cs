using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTrading.Model
{
    /// <summary>
    /// Class to contain the connection data used for the TWS
    /// </summary>
    public class ConnectionData
    {
        /// <summary>
        /// Default connection information, ClientID is used to distinguish between different connected clients
        /// These can be changed in the TWS advances settings
        /// </summary>
        private string Host { get; set; } = "127.0.0.1";
        private int Port { get; set; } = 7497;
        private int ClientId { get; set; } = 0;

        /// <summary>
        /// Default constructor for default data
        /// </summary>
        public ConnectionData() { }

        public ConnectionData(string Host, int Port, int ClientId)
        {
            this.Host = Host;
            this.Port = Port;
            this.ClientId = ClientId;
        }
    }
}
