using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.dynami.model;
using org.dynami.model.reader;
using System.Collections.Generic;

namespace test
{
    [TestClass]
    public class EmployeeReaderTest
    {
        [TestMethod]
        public void TestReaderEmployee()
        {
            EmployeeReader reader = new EmployeeReader();
            List<Employee> employees = reader.read("../employees.csv");

            Assert.IsNotNull(employees);
        }
    }
}
