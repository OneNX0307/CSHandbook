using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefContainer
{
	class ServiceLocatorAdapter : ServiceLocatorImplBase
	{
		private MefCompositionContainer mefContainer;
		public ServiceLocatorAdapter(MefCompositionContainer container)
		{
			this.mefContainer = container;
		}
		protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
		{
			return this.mefContainer.GetAllInstances(serviceType);
		}

		protected override object DoGetInstance(Type serviceType, string key)
		{
			return this.mefContainer.GetInstance(serviceType, key);
		}
	}
}
