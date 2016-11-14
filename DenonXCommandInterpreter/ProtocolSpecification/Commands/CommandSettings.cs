using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenonXCommandInterpreter.ProtocolSpecification.Commands
{
    /// <summary>
    /// All command types. More info Denon AVR control protocol v.04 page 7
    /// </summary>
    public enum CommandTypes
    {
        PW,
        MV
    }

    public enum CommonAsciiCodes
    {
        CR = 0x0D
    }
}
