using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    [ServiceContract]
    public interface ICompanyPublicService
    {
        [OperationContract]
        string GetPublicInformation();
    }

    [ServiceContract]
    public interface ICompanyConfidentialService
    {
        [OperationContract]
        string GetConfidentialInformation();
    }
}
