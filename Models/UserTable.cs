using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TheHighestLevel.Models
{
    public class UserTable: Database
    {

        public UserTable()
        {
            string server = "localhost";
            string database = "thehighestlevel";
            string uid = "root";
            string password = "";

            Initialize(server, database, uid, password);
        }

        public DataTable GetUserTable()
        {
            string query = "SELECT * FROM scoreboard";
            return GetDataTable(query);
        }

        public void Add(string username, int fail, int success)
        {
            string query = "INSERT INTO scoreboard (username, fail, success)"
                            + "VALUES('" + username + "',"
                            + fail + "," + success + ")";

            ExecuteQuery(query);
        }

        public bool Find(string username)
        {
            string query = "SELECT * FROM scoreboard WHERE username='" + username + "'";

            if (GetQuery(query))
            {
                return true;
            }
            return false;
        }

        public void Update(string username, int fail, int success)
        {
            string query = "UPDATE scoreboard SET fail=" + fail
                            + ", success=" + success
                            + " WHERE username='" + username + "'";

            ExecuteQuery(query);
        }

        public void Delete(string username)
        {
            string query = "DELETE FROM scoreboard WHERE username='" + username + "'";

            ExecuteQuery(query);
        }
    }
}
