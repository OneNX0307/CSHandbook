using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFCallback.Contract
{
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void DoCallback(double a, double b, double result);
    }
}
