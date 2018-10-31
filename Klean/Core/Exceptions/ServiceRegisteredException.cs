using Oxide.Ext.Klean.API;
using Oxide.Ext.Klean.API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uMod.Plugins;

namespace Oxide.Ext.Klean.Core.Exceptions
{
    public sealed class ServiceRegisteredException : KleanException
    {
        public KleanService Service { get; }

        public ServiceRegisteredException(KleanService service) : base($"Service {service.Name} is already registered", service.Plugin)
        {
            Service = service;
        }
    }
}
