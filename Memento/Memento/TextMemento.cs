using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextMemento
    {
        public string State { get; }

        public TextMemento(string state)
        {
            State = state;
        }
    }

}
