using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace org.dynami.model
{
    public class Employee
    {

        public int EmployeeNumber;

        public string FirstName;

        public string LastName;

        public string DepartmentName;

        public string District;

        public string Site;

        public string OnSiteDepartment;

        public DateTime HireDate;

        public string LocationName;

        public string PositionName;

        public string ManagerDisplayName;

        [NullValues]
        public DateTime? TerminationDate;

        public string EmploymentStatusName;

        [NullValues]
        [Default(false)]
        public Boolean? IsVoluntaryTermination;

        public string TerminationRegretType;

        public string EmployeeGender;

        public DateTime EmployeeBirthDate;

        public string PrimaryAddressCity;

        public string MaritialStatusName;

        public string ShiftRotationName;

        public string JobLevel;

    }
}
