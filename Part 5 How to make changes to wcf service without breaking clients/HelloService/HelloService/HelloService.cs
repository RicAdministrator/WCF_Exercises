using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    public class HelloService : IHelloServiceChanged
    {
        public string GetMessageChanged(string name)
        {
            return "Hello " + name;
        }
    }
}
