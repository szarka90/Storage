using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class DatabaseConnect
    {
        string server;
        string user;
        uint port;
        string password;
        string database;

        public DatabaseConnect(string server, string user, uint port, string password, string database)
        {
            Server = server;
            User = user;
            Port = port;
            Password = password;
            Database = database;
        }

        public string Server { get => server; set => server = value; }
        public string User { get => user; set => user = value; }
        public uint Port { get => port; set => port = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }
    }
}
