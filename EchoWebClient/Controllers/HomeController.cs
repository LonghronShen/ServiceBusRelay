using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace EchoWebClient.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.AutoDetect;

			ChannelFactory<IEchoChannel> channelFactory = new ChannelFactory<IEchoChannel>("RelayEndpoint");
			IEchoChannel channel = channelFactory.CreateChannel();
			channel.Open();

			channel.Echo("1231321312");

			return View();
		}
	}
}
