using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo.CalculatorService.Contract
{
    [ServiceContract(Namespace = "http://WCFDemo.com")]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        double Sub(double x, double y);

        [OperationContract]
        double Mul(double x, double y);

        [OperationContract]
        double Div(double x, double y);
    }
}
