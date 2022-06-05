using System;

namespace Server
{
    public class clsServer : MarshalByRefObject
    {
        public DateTime getServerTime()
        {
            return DateTime.Now;
        }
    }
}