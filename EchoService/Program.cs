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
			ServiceHost host = new ServiceHost(typeof(EchoService));

			host.Open();

			Console.WriteLine("Press [Enter] to exit");
			Console.ReadLine();

			host.Close();
		}
	}
}
