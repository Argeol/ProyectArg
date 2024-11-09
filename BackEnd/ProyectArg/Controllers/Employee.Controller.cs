using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using ProyectArg.Models;
using ProyectArg.Services;

namespace ProyectArg.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("Register Employee")]
        public IActionResult RegisterEmployee([FromBody] Employee employee)
        { 
            try
            {
                _employeeService.RegisterEmployee(employee);
                return Ok("Empleado Registrado Con Exito");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployees();
                return Ok(employees);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
