using System.ServiceModel;

namespace EchoClient
{
	public interface IEchoChannel : IEchoContract, IClientChannel
	{

	}
}
