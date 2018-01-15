
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using XSockets;
using XSockets.Core.Common.Socket;
using XSockets.Core.Utility.MessageQueue.Interceptors;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;
using XSockets.Plugin.Framework;
using XSockets.Plugin.Framework.Attributes;

namespace TestXSocket
{

    class  main{
        static void Main(string[] args)
        {
            //System.Threading.Thread.Sleep(3000);
            var c = new XSocketClient("ws://127.0.0.1:4502", "http://localhost", "generic");
            
            c.OnConnected += (sender, eventArgs) => Console.WriteLine("Connected");
            c.Controller("generic").OnOpen += (sender, connectArgs) => Console.WriteLine("Generic Open");

            c.Open();
            c.Controller("generic").Invoke("CallAllClients");
            c.Controller("generic").On("test", () => Console.WriteLine("Syntaxerror did it!!! "));
            Console.ReadLine();
        }

      
    }
    

}
