using System;
using SQLite.Net;
using Xamarin.Forms;

namespace Loginsamaple
{
    
    public class DataAccess
    {
        SQLiteConnection dbConn;

        public object Navigation { get; private set; }

        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            dbConn.CreateTable<Employee>();
        }
        public int SaveEmployee(Employee aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }
        public System.Collections.Generic.List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");

           
        }
        public System.Collections.Generic.List<Employee> GetEmployee(string email)
        {
            return dbConn.Query<Employee>("Select * From Employee where Email= ?",email);


        }

    }
}
