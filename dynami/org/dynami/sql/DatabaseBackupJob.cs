using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace dynami.org.dynami.sql
{
    public class DatabaseBackupJob
    {
        public static void BackUp()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dynamiconnection"].ConnectionString;

            // read backup folder from config file ("C:/temp/")
            var backupFolder = ConfigurationManager.AppSettings["BackupFolder"];

            var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);

            // set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
            var backupFileName = String.Format("{0}{1}-{2}.bak",
                backupFolder, sqlConStrBuilder.InitialCatalog,
                DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));

            using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
            {
                var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                    sqlConStrBuilder.InitialCatalog, backupFileName);

                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {

                    
                    connection.Open();
                    command.ExecuteNonQuery();
                        
                    }
                    catch(SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

    }
}
