using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefContainer
{
	public interface ICompositionContainer
	{
		IEnumerable<object> GetAllInstances(Type type);
		IEnumerable<T> GetAllInstances<T>();

		object GetInstance(Type type);
		T GetInstance<T>();
		T GetInstance<T>(string key);
		object GetInstance(Type type, string key);
	}
}
