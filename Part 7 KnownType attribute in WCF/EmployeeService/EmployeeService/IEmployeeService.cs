using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(Int32 Id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
