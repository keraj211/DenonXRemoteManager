using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenonXCommandInterpreter.ProtocolSpecification.Commands
{
    public class CommandFactory : IFactory
    {
        public string GetMessage(IMessage msg)
        {
            throw new NotImplementedException();
        }

        public IMessage GetMessage(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
