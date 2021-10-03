using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSide.Dependency_Injection
{
    interface ICustomerService
    {
        string Uid { get; set; }
        Customer GetCustomerById(int Id);
    }
}
