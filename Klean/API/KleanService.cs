using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uMod.Plugins;

namespace Oxide.Ext.Klean.API
{
    public abstract class KleanService
    {
        public string Name { get; }
        public CovalencePlugin Plugin { get; set; }

        public KleanService(string name, CovalencePlugin plugin)
        {
            Name = name;
            Plugin = plugin;
        }

        public event EventHandler ServiceStart;
        public event EventHandler ServiceEnd;
        
        public void OnServiceStart()
        {
            ServiceStart?.Invoke(this, EventArgs.Empty);
        }

        public void OnServiceEnd()
        {
            ServiceEnd?.Invoke(this, EventArgs.Empty);
        }
    }
}
