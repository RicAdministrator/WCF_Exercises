using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingService
{
    // to make a class remotable, inherit from MarshalByRefObject
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
