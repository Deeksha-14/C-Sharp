using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DocumentFormat.OpenXml.Drawing.Charts;
using MySql.Data.MySqlClient;
using BOL;



namespace DAL
{
    public class DBManager
    {
        //A connection String is a key value pair representation of the necessery information to connect to a database.
        // The @ symbol before the connection string is used to create a verbatim string literal in C#. 
        //This means that escape sequences (like \n, \t, etc.) are not processed, and the connection string can span multiple lines for better readability.
        public static string conString = @"server=localhost;port=3306;user=root;password=root123;database=dotnet";



        public static bool insert(Department dept)
        {
            bool status = false;
            string query = "insert into department(Id,Name,Location)" + " values('" + dept.Id + "','" + dept.Name + "','" + dept.Location + "')";
            //string query = "insert into department (id,name,location)" + "Values('" + dept.Id + "','" + dept.Name + "','" + dept.Location + "')";

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            //ConnectionString - get or set the string used to connect to mysql database

            try
            {
                con.Open();

                MySqlCommand con2 = new MySqlCommand(query,con);

                con2.ExecuteNonQuery();
                status = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { con.Close(); }


            return status;
        }
    }
}
