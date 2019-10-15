using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitilaizeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // make sql connection
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);


            } 
            if (textFiles)
            {
                // TODO - Create text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);

            }
        }
    }
}
