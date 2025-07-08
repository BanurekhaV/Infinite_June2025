using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using InfiniteRemotingServer;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel c1 = new HttpChannel(8003);
            ChannelServices.RegisterChannel(c1);

            //create a service class object
            InfiniteServices services = (InfiniteServices)Activator.GetObject(typeof(
                InfiniteServices), "http://localhost:83/OurRemoteService");
            
            InfiniteServer server = (InfiniteServer)Activator.GetObject(typeof(
                InfiniteServer), "http://localhost:83/OurInfiniteServer");
            //start making calls to the remote object
            Console.WriteLine(services.WriteData(12, 20));
            Console.WriteLine(server.Greetings());
            Console.Read();
        } 
    }
}
