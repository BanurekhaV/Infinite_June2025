using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using InfiniteRemotingServer;

namespace InfiniteServicesHost
{
    class Server
    {
        static void Main(string[] args)
        {
            //create a new channel
            HttpChannel c = new HttpChannel(83);

            //register the channel
            ChannelServices.RegisterChannel(c);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(InfiniteServices), "OurRemoteService",
                            WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(InfiniteServer), "OurInfiniteServer",
                            WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Started at Port No. 83...");
            Console.WriteLine("Press any Key to Stop the Server...");
            Console.Read();
        }
    }
}
