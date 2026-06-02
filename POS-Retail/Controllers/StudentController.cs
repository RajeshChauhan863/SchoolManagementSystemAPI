using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;

        }

        // GET: ProductController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Student Details(int id)
        {
            var data = studentService.GetStudentById(id);
            return data;
        }

        
        // POST: ProductController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Student model)
        {
            try
            {
                studentService.AddStudent(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: ProductController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditStudent")]
        public void Edit(int id, Student model)
        {
            try
            {
                studentService.UpdateStudent(model);
            }
            catch
            {
                return;
            }
        }

        // GET: ProductController/Delete/5
        [HttpGet]
        [Route("StudentDelete")]
        public string Delete(int id)
        {
            studentService.DeleteStudent(id);

            return "Deleted Record Successfully";
        }

    }
}
