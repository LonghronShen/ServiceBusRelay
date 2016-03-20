using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sino.ServiceBus.Demo
{
	public interface IEchoChannel : IEchoContract , IClientChannel
	{

	}
}
