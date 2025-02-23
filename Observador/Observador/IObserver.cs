using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador
{
    public interface IObserver
    {
        void Update(string productName);
    }

}
