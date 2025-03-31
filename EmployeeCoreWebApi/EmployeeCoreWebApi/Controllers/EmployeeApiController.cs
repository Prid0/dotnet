using EmployeeCoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        public readonly EmoloyeeContext Edb;
        public EmployeeApiController(EmoloyeeContext Edb)
        {
            this.Edb = Edb;
        }

        [HttpGet]
        public async Task<IActionResult> getAllEmployee()
        {
            var data = await Edb.Employees.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getEmplopyeeById(int id)
        {

            var data = await Edb.Employees.FindAsync(id);

            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.EmployeeName) || string.IsNullOrEmpty(emp.FatherName) || string.IsNullOrEmpty(emp.Gender) || string.IsNullOrEmpty(emp.Post))
            {
                return BadRequest();
            }
            else
            {
                Edb.Employees.AddAsync(emp);
                await Edb.SaveChangesAsync();
                return Ok(emp);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateEmployee(int id, Employee emp)
        {
            if (id != emp.Eid)
            {
                return NotFound();
            }

            //Edb.Entry(emp).State = EntityState.Modified;
            //Edb.SaveChangesAsync();
            //return Ok(Edb);

            var data = await Edb.Employees.FindAsync(id);
            if (data != null)
            {
                data.EmployeeName = !string.IsNullOrEmpty(emp.EmployeeName) ? emp.EmployeeName : data.EmployeeName;
                data.FatherName = !string.IsNullOrEmpty(emp.FatherName) ? emp.FatherName : data.FatherName;
                data.Post = !string.IsNullOrEmpty(emp.Post) ? emp.Post : data.Post;
                data.Gender = !string.IsNullOrEmpty(emp.Gender) ? emp.Gender : data.Gender;
                await Edb.SaveChangesAsync();
                return Ok(emp);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteEmployee(int id)
        {
            var employee = await Edb.Employees.FindAsync(id);
            if (employee != null)
            {
                Edb.Employees.Remove(employee);
                await Edb.SaveChangesAsync();
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
