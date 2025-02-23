using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class AuthorizationHandler : HandlerBase
    {
        public override void Handle(Request request)
        {
            if (request.UserRole == "Admin")
            {
                Console.WriteLine("✅ Usuario autorizado.");
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("❌ Error: Usuario no autorizado.");
            }
        }
    }
}
