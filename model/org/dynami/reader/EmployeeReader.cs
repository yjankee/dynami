using CsvHelper;
using org.dynami.map;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace org.dynami.model.reader
{
   public class EmployeeReader
    {        
        public List<Employee> Read(String csvpath)
        {
            var reader = new CsvReader(new StreamReader(csvpath), CultureInfo.InvariantCulture);
            reader.Configuration.HeaderValidated = null;
            reader.Configuration.MissingFieldFound = null;
            reader.Configuration.RegisterClassMap(new EmployeeMap());

            List<Employee> records = new List<Employee>();

            while (reader.Read())
            {
                Employee record = reader.GetRecord<Employee>();                
                records.Add(record);
            }

            return records;
        }
    }
}
