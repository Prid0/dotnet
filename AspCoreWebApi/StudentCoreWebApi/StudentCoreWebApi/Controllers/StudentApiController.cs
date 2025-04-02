using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCoreWebApi.Models;

namespace StudentCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly StudentsDetailsContext db;

        // Constructor to inject DbContext
        public StudentApiController(StudentsDetailsContext db)
        {
            this.db = db;
        }

        // GET api/studentapi
        [HttpGet]
        public async Task<IActionResult> GetStudentData()
        {
            // Fetching the student data from the database
            var data = await db.Students.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentByID(int id)
        {
            var data = await db.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Addstudent(Student std)
        {
            await db.Students.AddAsync(std);
            await db.SaveChangesAsync();
            return Ok(std);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateStudentByID(int id, Student std)
        {
            var data = await db.Students.FindAsync(id);
            if (id != std.Id)
            {
                return BadRequest();
            }

            else
            {
                db.Entry(std).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return Ok(std);
            }

            //if (data != null)
            //{
            //    data.StudentName = !string.IsNullOrEmpty(std.StudentName) ? std.StudentName : data.StudentName;
            //    data.FatherName = !string.IsNullOrEmpty(std.FatherName) ? std.FatherName : data.FatherName;
            //    data.Standard = !string.IsNullOrEmpty(std.Standard) ? std.Standard : data.Standard;
            //    data.Gender = !string.IsNullOrEmpty(std.Gender) ? std.Gender : data.Gender;
            //    await db.SaveChangesAsync();
            //    return Ok(data);
            //}
            //else
            //{
            //    return NotFound();
            //}
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentByID(int id)
        {
            var std = await db.Students.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            else
            {
                db.Students.Remove(std);
                await db.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
