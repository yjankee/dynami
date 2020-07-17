using app.org.dynami.sql;
using dynami.org.dynami.sql;
using org.dynami.model;
using org.dynami.model.reader;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace dynami
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Back up Employee Table 
            DatabaseBackupJob.BackUp();

            //2. Drop Employee Table & Create it again 
            DatabaseCreateJob.Create();

            //3. Read the Employees.csv using CSVHelper
            EmployeeReader reader = new EmployeeReader();
            List<Employee> employees = reader.Read(ConfigurationManager.AppSettings["DataFile"]);

            //4. Insert each Employee into EmployeeTable
            SqlBulkCopyJob.Copy(employees);

            //5. Run All PLSQLs



            /*
             *  CALCULATED TABLES 
             *  
             *      STORED PROCEDURE 
             *          CALCULATE_HEADCOUNT_BY_DEMOGRAPHICS
             *  
             * 
             * 
             * 
             * 
             */

        }
    }
}
