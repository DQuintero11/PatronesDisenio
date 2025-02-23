using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextHistory
    {
        private Stack<TextMemento> _history = new Stack<TextMemento>();

        public void Save(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento Undo()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }

