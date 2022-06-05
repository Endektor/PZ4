using Server;
using System;
using System.Runtime.Remoting;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Client.exe.config", false);
            var server = new clsServer();
            Console.WriteLine(server.getServerTime());
            Console.ReadLine();
        }
    }
}
