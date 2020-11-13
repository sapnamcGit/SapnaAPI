using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDemoAPI.EntityData
{

    /// <summary>
    /// For adding anything new first add field 
    /// then run command "Add-Migration [NewName]
    /// eg: Add-Migration EmployeeCity'. This creates a file in Migrations folder. Which will have all histor of migrations.
    /// then run command update-database to update DB table 
    /// </summary>
    public class Employee
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
