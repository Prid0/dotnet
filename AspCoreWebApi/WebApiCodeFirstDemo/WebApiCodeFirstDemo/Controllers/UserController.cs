using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCodeFirstDemo.Models;

namespace WebApiCodeFirstDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly UserContext db;
        public UserController(UserContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> getAllUser()
        {
            var data = await db.Users.ToListAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> addUser(UserModel user)
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getUserByID(int id)
        {
            var user = await db.Users.FindAsync(id);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateUser(int id, UserModel user)
        {
            if (id != user.ID)
            {
                return BadRequest("ID mismatch");
            }

            var userdata = await db.Users.FindAsync(id);
            if (userdata == null)
            {
                return NotFound();
            }
            userdata.username = !string.IsNullOrEmpty(user.username) ? user.username : userdata.username;
            userdata.userEmail = !string.IsNullOrEmpty(user.userEmail) ? user.userEmail : userdata.userEmail;
            userdata.Gender = !string.IsNullOrEmpty(user.Gender) ? user.Gender : userdata.Gender;
            userdata.Department = !string.IsNullOrEmpty(user.Department) ? user.Department : userdata.Department;

            await db.SaveChangesAsync();
            return Ok(userdata);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteUser(int id)
        {
            var Duser = await db.Users.FindAsync(id);
            if (Duser != null)
            {
                db.Users.Remove(Duser);
                await db.SaveChangesAsync();
                return Ok(Duser);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
