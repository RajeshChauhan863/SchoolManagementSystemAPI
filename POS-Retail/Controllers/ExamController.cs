using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        IExamService examService;

        public ExamController(IExamService _examService)
        {
            examService = _examService;

        }
        


        // GET: CustomerController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Exam Details(int id)
        {
            var data = examService.GetExamById(id);
            return data;
        }

        // GET: CustomerController/Create

        // POST: CustomerController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]
        
        public void Create(Exam model)
        {
            try
            {
                examService.AddExam(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: CustomerController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditExam")]
        public void Edit(int id, Exam model)
        {
            try
            {
                examService.UpdateExam(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CustomerController/Delete/5
        [HttpGet]
        [Route("ExamDelete")]
        public string Delete(int id)
        {
            examService.DeleteExam(id);

            return "Deleted Record Successfully";
        }


    }
}
