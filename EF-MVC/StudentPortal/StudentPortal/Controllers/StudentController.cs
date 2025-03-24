using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Data;
using StudentPortal.Models;
using StudentPortal.Models.Entities;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        public ApplicationContext Dbcontext { get; }
        public StudentController(ApplicationContext dbcontext)
        {
            this.Dbcontext = dbcontext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentView viewmodel)
        {
            var student = new StudentIdentity
            {
                Name = viewmodel.Name,
                Email = viewmodel.Email,
                Phone = viewmodel.Phone,
                Subscrebed = viewmodel.Subscrebed
            };
            await Dbcontext.students.AddAsync(student);
            await Dbcontext.SaveChangesAsync();
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {
            var students = await Dbcontext.students.ToListAsync();
            return View(students);
        }


        [HttpGet]

        public async Task<IActionResult> Edit(Guid id)
        {
            var Foundstudents = await Dbcontext.students.FindAsync(id);
            return View(Foundstudents);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentIdentity viewmodel)
        {
            var students = await Dbcontext.students.FindAsync(viewmodel.Id);
            if (students is not null)
            {
                students.Id = viewmodel.Id;
                students.Name = viewmodel.Name;
                students.Phone = viewmodel.Phone;
                students.Email = viewmodel.Email;
                students.Subscrebed = viewmodel.Subscrebed;

                await Dbcontext.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(StudentIdentity viewmodel)
        {
            var student = await Dbcontext.students.FindAsync(viewmodel.Id);

            if (student != null)
            {
                Dbcontext.students.Remove(student);

                await Dbcontext.SaveChangesAsync();
            }

            return RedirectToAction("List");
        }


    }
}
