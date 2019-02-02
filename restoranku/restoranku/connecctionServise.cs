using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace restoranku
{
    class connecctionServise
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection con = null;
            try
            {
                string sCounString = "server=localhost;database = login;uid = root;password =;";
                con = new MySqlConnection(sCounString);
            }
            catch (MySqlException nex)
            {
                throw new Exception(nex.Message.ToString());
            }
            return con;

        }
    }
}