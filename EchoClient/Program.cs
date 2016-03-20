using Microsoft.ServiceBus;
using System;
using System.ServiceModel;

namespace EchoClient
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.AutoDetect;

			Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", "sinoapi", "EchoService");
			TransportClientEndpointBehavior sasCredential = new TransportClientEndpointBehavior();
			sasCredential.TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "key");

			ChannelFactory<IEchoChannel> channelFactory = new ChannelFactory<IEchoChannel>("RelayEndpoint", new EndpointAddress(serviceUri));
			channelFactory.Endpoint.EndpointBehaviors.Add(sasCredential);

			IEchoChannel channel = channelFactory.CreateChannel();
			channel.Open();

			Console.WriteLine("Enter text to echo (or [Enter] to exit):");
			string input = Console.ReadLine();
			while(input != string.Empty)
			{
				try
				{
					Console.WriteLine("Server echoed: {0}", channel.Echo(input));
				}
				catch(Exception e)
				{
					Console.WriteLine("Error: " + e.Message);
				}
				input = Console.ReadLine();
			}

			channel.Close();
			channelFactory.Close();
		}
	}
}
