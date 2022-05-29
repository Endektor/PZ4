using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objRemote = Activator.GetObject(typeof(IServer.IServer), "http://localhost/server/server.soap") as IServer.IServer;

            Console.Write(objRemote.getServerTime());
            Console.ReadLine();
        }
    }
}
