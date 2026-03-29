using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetPublicInformation()
        {
            return "This is public information and available over HTTP to all general public outside the FireWall";
        }

        public string GetConfidentialInformation()
        {
            return "This is confidential information and only available over TCP behind the company FireWall";
        }
    }
}
