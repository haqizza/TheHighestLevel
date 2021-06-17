using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TheHighestLevel.Models
{
    public class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        // Buat data table
        private DataTable table;
        
        public Database()
        {

        }

        public Database(string server, string database, string uid, string password)
        {
            Initialize(server, database, uid, password);
        }

        public void Initialize(string server, string database, string uid, string password)
        {
            server = "localhost";
            database = "thehighestlevel";
            uid = "root";
            password = "";
            
            // String untuk configure koneksi
            string connectionString;
            connectionString = "SERVER=" + server + ";" 
                                + "DATABASE=" + database + ";"
                                + "UID=" + uid + ";" 
                                + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                // Buka koneksi
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                // Tutup koneksi
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public DataTable GetDataTable(string query)
        {
            //Open connection
            if (this.OpenConnection())
            {
                // Buat data adapter untuk Data Grid View
                MySqlDataAdapter dataAdapter = new();
                
                // Buat Command
                dataAdapter.SelectCommand = new MySqlCommand(query, connection);

                // Initialize data table
                table = new();

                // Isi data adapter
                dataAdapter.Fill(table);

                // Tutup koneksi
                this.CloseConnection();

                // return table
                return table;
            }
            else
            {
                return table;
            }
        }

        public void ExecuteQuery(string query)
        {
            // Buka koneksi
            if (OpenConnection())
            {
                // Buat command and assign query dan connection
                MySqlCommand cmd = new(query, connection);

                // Execute command
                cmd.ExecuteNonQuery();

                // Tutup koneksi
                CloseConnection();
            }
        }

        public bool GetQuery(string query)
        {
            MySqlDataReader reader = null;
            bool exist = false;
            if (OpenConnection())
            {
                var command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                exist = reader.HasRows;
                while (reader.Read())
                {
                    Debug.WriteLine(reader["username"]);
                }
                CloseConnection();
            }
            return exist;
        }



    }
}
