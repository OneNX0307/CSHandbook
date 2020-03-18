using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefContainer
{
	public class MefCompositionContainer : ICompositionContainer
	{
		private CompositionContainer container;

		public MefCompositionContainer(ComposablePartCatalog catalog)
		{
			this.container = new CompositionContainer(catalog);
		}
		public IEnumerable<object> GetAllInstances(Type type)
		{
			var contract = AttributedModelServices.GetContractName(type);
			return this.container.GetExportedValues<object>(contract);
		}

		public IEnumerable<T> GetAllInstances<T>()
		{
			return this.container.GetExportedValues<T>();
		}

		public object GetInstance(Type type)
		{
			var contract = AttributedModelServices.GetContractName(type);
			return this.container.GetExports(type, null, contract).FirstOrDefault();
		}

		public T GetInstance<T>()
		{
			return this.container.GetExportedValue<T>();
		}

		public T GetInstance<T>(string key)
		{
			return this.container.GetExportedValue<T>(key);
		}

		public object GetInstance(Type type, string key)
		{
			var contract = AttributedModelServices.GetContractName(type);
			return this.container.GetExports(type, null, contract).FirstOrDefault().Value;
		}

		public void Config()
		{
			this.container.ComposeParts(this);
			ServiceLocatorAdapter serviceLocatorAdapter = new ServiceLocatorAdapter(this);
			ServiceLocator.SetLocatorProvider(() => serviceLocatorAdapter);
			this.container.ComposeExportedValue<IServiceLocator>(serviceLocatorAdapter);
			this.container.ComposeExportedValue<MefCompositionContainer>(this);
			this.container.ComposeExportedValue<ICompositionContainer>(this);
		}
	}
}
