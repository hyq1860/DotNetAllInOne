using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServer.Dao
{
    public class EcsentryContext:DbContext
    {
        public DbSet<JDCategory> JDCategory { get; set; }

        public EcsentryContext()
            : base("DataCenter")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }

    [Table("JDCategory")]
    public class JDCategory
    {
        public Int64 Id { get; set; } //注意要用Int64
        public string Item { get; set; }
    }

    

    public class NorthwindContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
