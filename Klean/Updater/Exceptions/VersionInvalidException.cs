using Oxide.Ext.Klean.API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uMod.Plugins;

namespace Oxide.Ext.Klean.Updater.Exceptions
{
    public sealed class VersionInvalidException : KleanException
    {
        public VersionInvalidException(CovalencePlugin plugin) : base("The supplied version is invalid", plugin) { }
    }
}
