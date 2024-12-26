using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DB
{
    public  class three_tier_api:DbContext
    {
        public three_tier_api(DbContextOptions<three_tier_api>options):base(options)
        {
        }
        public DbSet<Employeemaster> employeemasters { get; set; }
    }
}
