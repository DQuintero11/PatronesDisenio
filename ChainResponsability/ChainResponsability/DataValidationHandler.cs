using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class DataValidationHandler : HandlerBase
    {
        public override void Handle(Request request)
        {
            if (!string.IsNullOrEmpty(request.Data))
            {
                Console.WriteLine("✅ Datos validados correctamente.");
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("❌ Error: Datos inválidos.");
            }
        }
    }

}
