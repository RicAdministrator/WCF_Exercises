using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    [ServiceContract(Name = "IHelloService")]
    public interface IHelloServiceChanged
    {
        [OperationContract(Name = "GetMessage")]
        string GetMessageChanged(string name);
    }
}
