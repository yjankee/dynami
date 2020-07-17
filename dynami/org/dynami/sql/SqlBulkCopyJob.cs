using org.dynami.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace app.org.dynami.sql
{
    public class SqlBulkCopyJob
    {
        public static void Copy(List<Employee> employees)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["dynamiconnection"].ConnectionString;

            var dataTable = new DataTable();
            dataTable.Columns.Add("EmployeeNumber");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("District");
            dataTable.Columns.Add("DepartmentName");
            dataTable.Columns.Add("Site");
            dataTable.Columns.Add("OnSiteDepartment");
            dataTable.Columns.Add("HireDate");
            dataTable.Columns.Add("LocationName");
            dataTable.Columns.Add("PositionName");
            dataTable.Columns.Add("ManagerDisplayName");
            dataTable.Columns.Add("TerminationDate");
            dataTable.Columns.Add("EmploymentStatusName");
            dataTable.Columns.Add("IsVoluntaryTermination");
            dataTable.Columns.Add("TerminationRegretType");
            dataTable.Columns.Add("EmployeeGender");
            dataTable.Columns.Add("EmployeeBirthDate");
            dataTable.Columns.Add("PrimaryAddressCity");
            dataTable.Columns.Add("MaritialStatusName");
            dataTable.Columns.Add("ShiftRotationName");
            dataTable.Columns.Add("JobLevel");

            Dictionary<int, Employee> map = new Dictionary<int, Employee>();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(" Row " + employees.IndexOf(employee) + 1);

                if (!map.ContainsKey(employee.EmployeeNumber))
                {
                    dataTable.Rows.Add(employee.EmployeeNumber, employee.FirstName, employee.LastName, employee.District, employee.DepartmentName, employee.Site ?? (object)DBNull.Value, employee.OnSiteDepartment, employee.HireDate, employee.LocationName, employee.PositionName, employee.ManagerDisplayName, employee.TerminationDate, employee.EmploymentStatusName, employee.IsVoluntaryTermination, employee.TerminationRegretType, employee.EmployeeGender, employee.EmployeeBirthDate, employee.PrimaryAddressCity, employee.MaritialStatusName, employee.ShiftRotationName, employee.JobLevel);
                    map.Add(employee.EmployeeNumber, employee);
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var sqlBulk = new SqlBulkCopy(connectionString))
                {
                    sqlBulk.DestinationTableName = "EmployeeTable";
                    sqlBulk.WriteToServer(dataTable);
                }

            }
        }
    }
}
