using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenonXCommandInterpreter.ProtocolSpecification.Commands
{
    public sealed class MV : ICommand
    {
        #region CTOR

        private MV()
        {
        }

        public MV(string msg)
        {
            Parameter = msg;
        }

        #endregion

        #region Properties

        public string Parameter { get; }

        #endregion

        #region Methods

        public ICommand ParseFromString(string msg)
        {
            return new MV();
        }

        public string ParseToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{1}{2}{3}", Enum.Parse(typeof(CommandTypes), this.GetType().ToString()) + Parameter + CommonAsciiCodes.CR);

            return sb.ToString();
        }

        #endregion
    }
}
