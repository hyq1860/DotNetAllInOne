using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace AppServer
{
    public class MessageHub : Hub
    {
        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}
