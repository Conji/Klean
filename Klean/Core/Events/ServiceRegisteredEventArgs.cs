using Oxide.Ext.Klean.API;
using Oxide.Ext.Klean.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Ext.Klean.Core.Events
{
    public class ServiceRegisteredEventArgs : KleanEventArgs
    {
        public KleanService Service { get; }

        public ServiceRegisteredEventArgs(KleanService service)
        {
            Service = service;
        }
    }
}
