using Oxide.Ext.Klean.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Oxide.Ext.Klean.Core.Exceptions;
using uMod.Plugins;
using Oxide.Ext.Klean.Core.Events;

namespace Oxide.Ext.Klean.Core
{
    public sealed class ServicesContainer : IEnumerable<KleanService>
    {
        private HashSet<KleanService> m_RegisteredServices = new HashSet<KleanService>();
        
        public ServicesContainer()
        {

        }

        public event EventHandler<ServiceRegisteredEventArgs> ServiceRegistered;
        public event EventHandler<ServiceUnregisteredEventArgs> ServiceUnregistered;

        public void OnServiceRegistered(KleanService service)
        {
            ServiceRegistered?.Invoke(this, new ServiceRegisteredEventArgs(service));
        }

        public void OnServiceUnregistered(KleanService service)
        {
            ServiceUnregistered?.Invoke(this, new ServiceUnregisteredEventArgs(service));
        }

        public void RegisterService(KleanService service)
        {
            if (m_RegisteredServices.Any(s => s.Plugin == service.Plugin && s.Name == service.Name))
            {
                throw new ServiceRegisteredException(service);
            }
        }

        public IEnumerator<KleanService> GetEnumerator()
        {
            return m_RegisteredServices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_RegisteredServices.GetEnumerator();
        }
    }
}
