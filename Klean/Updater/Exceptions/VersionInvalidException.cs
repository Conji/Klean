using Oxide.Ext.Klean.API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Ext.Klean.Updater.Exceptions
{
    public class VersionInvalidException : KleanException
    {
        public VersionInvalidException() : base("The supplied version is invalid") { }
    }
}
