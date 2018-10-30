using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Ext.Klean.API.Exceptions
{
    public class KleanException : Exception
    {
        public KleanException(string message) : base(message) { }

        public KleanException(string message, Exception innerException) : base(message, innerException) { }
    }
}
