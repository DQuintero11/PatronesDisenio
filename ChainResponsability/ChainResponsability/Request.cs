using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class Request
    {
        public bool UserAuthenticated { get; set; }
        public string UserRole { get; set; }
        public string Data { get; set; }
    }
}
