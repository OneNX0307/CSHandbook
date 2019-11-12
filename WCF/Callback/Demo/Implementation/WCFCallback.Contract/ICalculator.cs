using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFCallback.Contract
{
    [ServiceContract(Namespace = "http://xingyafei.me", CallbackContract = typeof(ICallback))]
    public interface ICalculator
    {
        [OperationContract]
        void Add(double a, double b);
    }
}
