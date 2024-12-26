using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using DatabaseLayer.DB;
using DatabaseLayer.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services
{
    public class EmployeeServices : EmployeeINF
    {
        private readonly three_tier_api _three_tier_api;
        public EmployeeServices(three_tier_api three_Tier_Api)
        {
            _three_tier_api = three_Tier_Api;

        }

        public async Task<IEnumerable<Employeemaster>> employeeAllList()
        {
            var data = await _three_tier_api.employeemasters.ToListAsync();
            return (data);
        }

        public async Task<string> createEmployee(Employeemaster employeemaster)
        { 
            var data = new Employeemaster();
            {
                data.FirstName = employeemaster.FirstName;
                data.Name = employeemaster.Name;
                data.LastName = employeemaster.LastName;
                data.Email = employeemaster.Email;
                data.Phone = employeemaster.Phone;
                data.City = employeemaster.City;
                data.Country = employeemaster.Country;
                data.Phone = employeemaster.Phone;
                data.Pincode = employeemaster.Pincode;

                 _three_tier_api.employeemasters.AddAsync(data);
                  await _three_tier_api.SaveChangesAsync();
                return "success";
            }

        }

        public async Task<Employeemaster> EditEmployee(int id)
        {
            var data = await _three_tier_api.employeemasters.FirstOrDefaultAsync(getedit => getedit.Id == id);
           
            return data;
            
            
        }

        public async Task<string> PostEditEmployee(Employeemaster employeemaster)
         {
            var data = await _three_tier_api.employeemasters.FindAsync(employeemaster.Id);
            if (data != null)
            {
                data.FirstName = employeemaster.FirstName;
                data.Name = employeemaster.Name;
                data.LastName = employeemaster.LastName;
                data.Email = employeemaster.Email;
                data.Phone = employeemaster.Phone;
                data.City = employeemaster.City;
                data.Country = employeemaster.Country;
                data.Phone = employeemaster.Phone;
                data.Pincode = employeemaster.Pincode;

               
                    _three_tier_api.employeemasters.Update(data);
                    await _three_tier_api.SaveChangesAsync();
                    return "success";
            }
            else
            {
                    return "Not success";
            }

            
        }

        public async Task<string> DeleteEmployee(int id)
        {
            var data = await _three_tier_api.employeemasters.FindAsync(id);
            if(data != null)
            {
                _three_tier_api.employeemasters.Remove(data);
                await _three_tier_api.SaveChangesAsync();
                return "Remove Data";
            }
            else
            {
                return "Not Remove";
            }
        }
    }
}
