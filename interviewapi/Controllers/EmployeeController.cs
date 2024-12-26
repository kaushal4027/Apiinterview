using BusinessLayer.Interface;
using DatabaseLayer.DB;
using DatabaseLayer.Models.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace interviewapi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // private readonly three_tier_api _three_Tier_Api;
        private readonly EmployeeINF _employeeINF;
        public EmployeeController(EmployeeINF employeeINF)
        {
            // _three_Tier_Api = three_Tier_Api;
            _employeeINF = employeeINF;

        }


        [HttpGet]
        public async Task<IActionResult> EmpGetdata()
        {

            var data = await _employeeINF.employeeAllList();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> EmpCreateData(Employeemaster employeemaster)
        {
            try {
                if (employeemaster != null)
                {
                    var data = await _employeeINF.createEmployee(employeemaster);
                    return Ok(data);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }


        }

        [HttpGet("id")]
        public async Task<IActionResult> GetEmployeeEdit(int id)
        {
            var data = await _employeeINF.EditEmployee(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest("Not success");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EmpEdit(Employeemaster employeemaster)
        {
            var data = await _employeeINF.PostEditEmployee(employeemaster);

            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest("Not Success");
            }

        }

        [HttpPost("id")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var data = await _employeeINF.DeleteEmployee(id);
            if(data != null)
            {
                return Ok(new { message = data });
            }
            else
            {
                return BadRequest(new { message = data });
            }
        }
    }
}
