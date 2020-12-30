using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcConnector
{
    public static class Entry
    {
        public static Plc.PlcTwinController Plc = new Plc.PlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(851));
    }
}
