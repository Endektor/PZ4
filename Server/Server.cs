using System;

namespace Server
{
    public class clsServer : MarshalByRefObject, IServer.IServer
    {
        public DateTime getServerTime()
        {
            return DateTime.Now;
        }
    }
}