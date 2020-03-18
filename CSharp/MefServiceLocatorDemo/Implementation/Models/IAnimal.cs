using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public interface IAnimal
	{
		int Id { get; set; }
		string Name { get; set; }
		void Run();
	}
}
