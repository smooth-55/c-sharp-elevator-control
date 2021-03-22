using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{

    class database
    {

        public static OleDbConnection con;
        public static void DbConnection()//Global connection of the database
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ElevatorLog.mdb");
            con.Open();
        }

    }
}


