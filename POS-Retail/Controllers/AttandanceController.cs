using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttandanceController : ControllerBase
    {
        IAttandanceService attandanceService;

        public AttandanceController(IAttandanceService _attandanceService)
        {
            attandanceService = _attandanceService;

        }



        // GET: AttandanceController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Attandance Details(int id)
        {
            var data = attandanceService.GetAttandanceById(id);
            return data;
        }

        // GET: AttandanceController/Create

        // POST: AttandanceController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Attandance model)
        {
            try
            {
                attandanceService.AddAttandance(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: AttandanceController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditAttandance")]
        public void Edit(int id, Attandance model)
        {
            try
            {
                attandanceService.UpdateAttandance(model);
            }
            catch
            {
                return;
            }
        }

        // GET: AttandanceController/Delete/5
        [HttpGet]
        [Route("AttandanceDelete")]
        public string Delete(int id)
        {
            attandanceService.DeleteAttandance(id);

            return "Deleted Record Successfully";
        }


    }
}

