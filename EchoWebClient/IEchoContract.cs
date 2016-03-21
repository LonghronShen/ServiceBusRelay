using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EchoWebClient
{
	[ServiceContract(Name = "IEchoContract", Namespace = "http://demo.vip56.cn/ServiceModel/Relay/")]
	public interface IEchoContract
	{
		[OperationContract]
		string Echo(string text);
	}
}
