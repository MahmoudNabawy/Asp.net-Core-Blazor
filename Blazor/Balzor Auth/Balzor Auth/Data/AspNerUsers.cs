using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balzor_Auth.Data
{
    public class AspNerUsers : IdentityUser
    {
        public string School { get; set; }
    }
}
