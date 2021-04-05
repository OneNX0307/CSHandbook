using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
	[ServiceContract]
	public interface ICalculatorService
	{
		[OperationContract]
		double Add(double x, double y);
	}
}
