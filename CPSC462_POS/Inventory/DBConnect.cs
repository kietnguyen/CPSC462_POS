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

            connection = new MySqlConnection(connectionString);
        }

        #region General mySql commands

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

        /// <summary>
        /// Execute insert command and return its insert id.
        /// </summary>
        /// <param name="query">Query command</param>
        /// <returns>Last insert id (unsigned bigit)</returns>
        public UInt64 Insert2(string query)
        {
            UInt64 result = 0;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                using (cmd.ExecuteReader()) { }

                // Create and execute command to get last insert id
                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read and store the insert id
                    if (dataReader != null && dataReader.Read())
                        result = dataReader.GetUInt64(0);
                }

                //close connection
                this.CloseConnection();
            }

            if (result == 0)
            {
                MessageBox.Show("Failed to insert data to database");
                System.Environment.Exit(-1);
            }

            return result;
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

        //Select statement
        private List<string>[] Select(string query)
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
        private int Count(string query)
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

        #endregion


        #region mySql Expert Information

        /// <summary>
        /// Find and return the unique Item object. By executing SELECT command.
        /// </summary>
        /// <param name="itemId">Unique item id</param>
        /// <returns>Item object</returns>
        public Item retrieveItem(int itemId)
        {
            string query = "SELECT p.name, p.manufacture, p.description, i.price " +
                            "FROM Item AS i " +
                            "LEFT JOIN ProdSpec AS p " +
                            "ON i.specid = p.specid " +
                            "WHERE i.itemId = " + itemId;

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            for (int i = 0; i < 4; i++)
                list[i] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["name"] + "");
                        list[1].Add(dataReader["manufacture"] + "");
                        list[2].Add(dataReader["description"] + "");
                        list[3].Add(dataReader["price"] + "");
                    }
                }

                //close Connection
                this.CloseConnection();
            }

            if (list[0].Count == 0 || list[0].Count > 1)
            {
                MessageBox.Show("Invalid item id.");
                return null;
            }

            ProductSpecification spec = new ProductSpecification(list[0][0], list[1][0], list[2][0]);
            Item item = new Item(itemId, spec, Convert.ToDecimal(list[3][0]));

            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="register"></param>
        public void insertReceipt(Register register)
        {
            string query = "INSERT Receipt(saleDate, storeId, registerId, employeeId) " +
                            "VALUES ('" + register.Sale.SaleDate.ToString("yyyy-MM-d hh:mm:ss") + "'," +
                             register.Store.Id + "," + register.Id + "," + register.Cashier.EmployeeId + ")";
            UInt64 receiptId = Insert2(query);

            foreach (SalesLineItem lineItem in register.Sale.ItemList)
            {
                query = "INSERT SalesLineItem(qty, itemId) " +
                            "VALUES (" + lineItem.Quantity + "," + lineItem.ProductId + ")";
                UInt64 saleId = Insert2(query);

                query = "INSERT LineItemReceipt(saleId, receiptId) " +
                            "VALUES (" + saleId + "," + receiptId + ")";
                Insert2(query);
            }

            foreach (PaymentMethod payment in register.Sale.Payments)
            {
                // Hard code
                int paymentTypeId = 0;
                switch (payment.GetType().Name)
                {
                    case "CashPayment":
                        paymentTypeId = 1;
                        break;
                    case "CheckPayment":
                        paymentTypeId = 2;
                        break;
                    case "CreditCardPayment":
                        paymentTypeId = 3;
                        break;
                }
                if (paymentTypeId == 0)
                {
                    MessageBox.Show("Undefined payment method.");
                    System.Environment.Exit(-1);
                }

                query = "INSERT Payment(paymentTypeId, amount) " +
                            "VALUES (" + paymentTypeId + "," + payment.Amount + ")";
                UInt64 paymentId = Insert2(query);

                query = "INSERT PaymentReceipt(receiptId, paymentId) " +
                            "VALUES (" + receiptId + "," + paymentId + ")";
                Insert2(query);
            }
        }

        #endregion

    }
}
