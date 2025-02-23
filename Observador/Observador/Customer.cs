using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador
{
    public class Customer : IObserver
    {
        private string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public void Update(string productName)
        {
            Console.WriteLine($"📩 {_name} ha sido notificado: '{productName}' está disponible en la tienda.");
        }
    }

}
