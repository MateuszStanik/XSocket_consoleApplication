using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using XSockets.Core.Common.Socket;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;
using XSockets.Plugin.Framework;
using XSockets.Plugin.Framework.Attributes;

namespace ServerXSocket
{

    public class Generic : XSocketController
    {
        public async Task CallAllClients()
        {
            await this.InvokeToAll("test");
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            using (var container = XSockets.Plugin.Framework.Composable.GetExport<IXSocketServerContainer>())
            {
                container.Start();
                Console.WriteLine("Serwer started!");
                Console.ReadLine();
            }
        }
    }
}
