using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcConnector
{

    public static class Entry
    {
        const string AmsId = "172.20.10.2.1.1";
        const int AmsPort = 851;

        public static Plc.PlcTwinController Plc = new Plc.PlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(AmsId, AmsPort));
    }
}
