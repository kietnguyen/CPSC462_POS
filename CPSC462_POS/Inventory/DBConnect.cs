using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CPSC462_POS
{
    //Reference: http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
    class DBConnect
    {
        private static DBConnect dbConnect = null;
        
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public static DBConnect GetInstance
        {
            get
            {
                if (dbConnect == null)
                    dbConnect = new DBConnect();
                return dbConnect;
            }
        }

        //Constructor
        private DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = Settings.DB.Default.db_server;
            database = Settings.DB.Default.db_name;
            uid = Settings.DB.Default.db_uid;
            password = Settings.DB.Default.db_password;
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
<<<<<<< HEAD
            */
            /*
            connectionString = "HOST=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection myConn = new MySqlConnection("host=server;protocol=SSH;user=root;password=root;database=test");
            connection = new MySqlConnection(connectionString);*/
=======
      
            connection = new MySqlConnection(connectionString);
>>>>>>> origin/newbranch
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Insert statement
        public void Insert(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Item retrieveItem(int itemId)
        {
            string query = @"SELECT p.name, p.manufacture, p.description, i.price
                            FROM item AS i
                            LEFT JOIN prodspec AS p 
                            ON i.specid = p.id
                            WHERE i.itemId = " + itemId;

            //Create a list to store the result
            //List<string>[] list = new List<string>[4];
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["name"] + "");
                    list.Add(dataReader["manufacture"] + "");
                    list.Add(dataReader["description"] + "");
                    list.Add(dataReader["price"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }

            //if (list == 0 || list.Length > 1) return null;

            ProductSpecification spec = new ProductSpecification(list[0], list[1], list[2]);
            Item item = new Item(itemId, spec, Convert.ToDecimal(list[3]));

            return item;
        }


        //Select statement
        public List<string>[] Select(string query)
        {
            //Create a list to store the result
            List<string>[] list = new List<string>[3];

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count(string query)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
