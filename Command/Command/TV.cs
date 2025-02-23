using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("📺 El televisor está ENCENDIDO.");
        }

        public void TurnOff()
        {
            Console.WriteLine("📺 El televisor está APAGADO.");
        }
    }

}
