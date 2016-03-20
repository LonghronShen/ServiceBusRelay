using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.ServiceBus;
using System.ServiceModel.Description;

namespace Sino.ServiceBus.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			TransportClientEndpointBehavior sasCredential = new TransportClientEndpointBehavior();
			sasCredential.TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("key");

			Uri address = ServiceBusEnvironment.CreateServiceUri("sb", "sinoapi", "EchoService");

			ServiceHost host = new ServiceHost(typeof(EchoService), address);

			IEndpointBehavior serviceRegisterySettings = new ServiceRegistrySettings(DiscoveryType.Public);

			foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
			{
				endpoint.EndpointBehaviors.Add(serviceRegisterySettings);
				endpoint.EndpointBehaviors.Add(sasCredential);
			}

			host.Open();

			Console.WriteLine("Service address: " + address);
			Console.WriteLine("Press [Enter] to exit");
			Console.ReadLine();

			host.Close();
		}
	}
}
