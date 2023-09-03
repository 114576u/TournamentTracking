using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections {  get; private set; } = new List<IDataConnection>();
        //public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        //public static void InitializeConnections(DatabaseType db)
        {

            if (database == true)
            //if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
                //Connections = sql;

            }
            if (textFiles == true)
            //else if (db == DatabaseType.TextFile)
            { 
            
                // TODO - Create the text connection
                TextConnector txt = new TextConnector();
                Connections.Add(txt);
                //Connections = txt;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            
        }
    }
}
