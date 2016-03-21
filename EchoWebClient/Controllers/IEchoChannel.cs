using System.ServiceModel;

namespace EchoWebClient.Controllers
{
	public interface IEchoChannel : IEchoContract , IClientChannel
	{

	}
}