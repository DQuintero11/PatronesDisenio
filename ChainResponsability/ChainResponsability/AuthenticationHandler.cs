using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class AuthenticationHandler : HandlerBase
    {
        public override void Handle(Request request)
        {
            if (request.UserAuthenticated)
            {
                Console.WriteLine("✅ Usuario autenticado.");
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("❌ Error: Usuario no autenticado.");
            }
        }
    }

}
