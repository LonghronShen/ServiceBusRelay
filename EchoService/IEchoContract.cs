using System.ServiceModel;

namespace Sino.ServiceBus.Demo
{
	[ServiceContract(Name = "IEchoContract", Namespace = "http://demo.vip56.cn/ServiceModel/Relay/")]
	public interface IEchoContract
	{
		[OperationContract]
		string Echo(string text);
	}
}
