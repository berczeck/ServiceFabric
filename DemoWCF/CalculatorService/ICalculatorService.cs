using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        [WebGet]
        Task<int> Add(int a, int b);
    }
    
    internal class WcfCalculatorService : ICalculatorService
    {
        public Task<int> Add(int a, int b)
        {
            return Task.FromResult(a + b);
        }
    }
}