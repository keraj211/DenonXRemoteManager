using DenonXCommandInterpreter.ProtocolSpecification.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenonXCommandInterpreter.ProtocolSpecification.Commands
{
    public interface ICommand
    {
        string Parameter { get; }

        ICommand ParseFromString(string msg);

        string ParseToString();
    }
}
