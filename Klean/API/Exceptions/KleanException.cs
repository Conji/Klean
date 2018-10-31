using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uMod.Plugins;

namespace Oxide.Ext.Klean.API.Exceptions
{
    public class KleanException : Exception
    {
        public CovalencePlugin Plugin { get; }

        public KleanException(string message, CovalencePlugin plugin) : base(message)
        {
            Plugin = plugin;
        }

        public KleanException(string message, Exception innerException, CovalencePlugin plugin) : base(message, innerException)
        {
            Plugin = plugin;
        }
    }
}
