using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenonXCommandInterpreter.ProtocolSpecification
{
    public interface IFactory
    {
        IMessage GetMessage(string msg);

        string GetMessage(IMessage msg);
    }
}
