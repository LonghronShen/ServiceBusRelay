using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EchoWebService
{
	[ServiceBehavior(Name = "EchoService", Namespace = "http://demo.vip56.cn/ServiceModel/Relay")]
	public class EchoContract : IEchoContract
	{
		public string Echo(string text)
		{
			return text;
		}
	}
}
