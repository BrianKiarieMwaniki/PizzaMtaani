using PizzaMtaani.UseCases.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMtaani.StateStore
{
    public class StateStoreBase : IStateStore
    {
        protected Action? listeners;
        public void AddStateChangeListeners(Action listener)
        {
            this.listeners += listener;
        }

        public void BroadcastStateChange()
        {
            if (this.listeners != null) this.listeners.Invoke();
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            this.listeners -= listener;
        }
    }
}
