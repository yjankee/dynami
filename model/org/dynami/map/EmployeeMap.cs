using CsvHelper.Configuration;
using org.dynami.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace org.dynami.map
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Map(m => m.EmployeeNumber).Name("Employee Number");
            Map(m => m.FirstName).Name("Employee First Name");
            Map(m => m.LastName).Name("Employee Last Name");
            Map(m => m.DepartmentName).Name("Department Name");
            Map(m => m.District).Name("District");
            Map(m => m.Site).Name("Site");
            Map(m => m.OnSiteDepartment).Name("On-Site Department");
            Map(m => m.HireDate).Name("Hire Date");
            Map(m => m.LocationName).Name("Location Name");
            Map(m => m.PositionName).Name("Position Name");
            Map(m => m.ManagerDisplayName).Name("Manager Display Name");
            Map(m => m.TerminationDate).Name("Termination Date");
            Map(m => m.EmploymentStatusName).Name("Employment Status Name");
            Map(m => m.IsVoluntaryTermination).Name("Is Voluntary Term");
            Map(m => m.TerminationRegretType).Name("Termination Regret Type");
            Map(m => m.EmployeeGender).Name("Employee Gender");
            Map(m => m.EmployeeBirthDate).Name("Employee Birth Date");
            Map(m => m.PrimaryAddressCity).Name("Primary Address City");
            Map(m => m.MaritialStatusName).Name("Marital Status Name");            
            Map(m => m.ShiftRotationName).Name("Shift Rotation Name");
            Map(m => m.JobLevel).Name("Job Level");

        }
    }
}
