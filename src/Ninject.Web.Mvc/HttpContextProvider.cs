using System;
using System.Web;
using Ninject.Activation;
using Ninject.Creation;

namespace Ninject.Web.Mvc
{
	public class HttpContextProvider : Provider<HttpContext>
	{
		protected override HttpContext CreateInstance(IContext context)
		{
			return HttpContext.Current;
		}
	}
}