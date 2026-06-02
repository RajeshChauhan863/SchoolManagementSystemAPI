using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        ITeacherService teacherService;

        public TeacherController(ITeacherService _teacherSrvice)
        {
            teacherService = _teacherSrvice;

        }



        // GET: PurchaseOrderController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Teacher Details(int id)
        {
            var data = teacherService.GetTeacherById(id);
            return data;
        }

        // GET: PurchaseOrderController/Create

        // POST: PurchaseOrderController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Teacher model)
        {
            try
            {
                teacherService.AddTeacher(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: PurchaseOrderController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditTeacher")]
        public void Edit(int id, Teacher model)
        {
            try
            {
                teacherService.UpdateTeacher(model);
            }
            catch
            {
                return;
            }
        }

        // GET: PurchaseOrderController/Delete/5
        [HttpGet]
        [Route("TeacherDelete")]
        public string Delete(int id)
        {
            teacherService.DeleteTeacher(id);

            return "Deleted Record Successfully";
        }

    }
}

