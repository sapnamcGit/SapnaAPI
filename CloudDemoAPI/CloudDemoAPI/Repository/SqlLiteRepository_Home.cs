using CloudDemoAPI.EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDemoAPI.Repository
{
    public interface ISqlLiteRepository_Home
    {
        void adddata_Employee();
        List<Employee> ShowALLEmployees();
    }

    public class SqlLiteRepository_Home :  ISqlLiteRepository_Home
    {
        private SQLiteDBContext _Sqllitedb;

        public SqlLiteRepository_Home(SQLiteDBContext dbCon)
        {
            _Sqllitedb = dbCon;


        }
        // Call this only to seed the DB first time
        public void adddata_Employee()
        {
            _Sqllitedb.Employees.Add(new Employee { FirstName = "Johni", LastName = "Doe", Age = 55, City = "CT" });
            _Sqllitedb.SaveChanges();
        }

        public List<Employee> ShowALLEmployees()
        {
            var employee = _Sqllitedb.Employees
                    .OrderBy(b => b.Id);
            return employee.ToList();
        }

    }
}
