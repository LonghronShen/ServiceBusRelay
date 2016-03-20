using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sino.ServiceBus.Demo
{
	[ServiceBehavior(Name = "EchoService", Namespace = "http://demo.vip56.cn/ServiceModel/Relay/")]
	public class EchoService : IEchoContract
	{
		public string Echo(string text)
		{
			Console.WriteLine("Echoing:{0}", text);
			return text;
		}
	}
}
