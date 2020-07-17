using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace app.org.dynami.sql
{
    public class DatabaseCreateJob
    {

        public static void Create()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dynamiconnection"].ConnectionString;
            FileInfo file = new FileInfo(ConfigurationManager.AppSettings["DatabaseScriptFile"]);
            string script = file.OpenText().ReadToEnd();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(script, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            connection.Close();
        }
        }
}
