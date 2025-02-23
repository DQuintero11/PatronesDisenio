using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(Request request);
    }
}
