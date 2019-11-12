using System.ServiceModel;
using WCFCallback.Contract;

namespace WCFCallback.Host
{
    public class CalculatorService : ICalculator
    {
        public void Add(double a, double b)
        {
            double result = a + b;
            ICallback callback = OperationContext.Current.GetCallbackChannel<ICallback>();
            callback.DoCallback(1, 2, result);
        }
    }
}
