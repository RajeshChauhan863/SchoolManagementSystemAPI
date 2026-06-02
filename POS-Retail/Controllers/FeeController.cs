using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeController : ControllerBase
    {
        IfeeService feeService;

        public FeeController(IfeeService _feeService)
        {
            feeService = _feeService;

        }



        // GET: CustomerController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Fee Details(int id)
        {
            var data = feeService.GetFeeById(id);
            return data;
        }

        // GET: CustomerController/Create

        // POST: CustomerController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Fee model)
        {
            try
            {
                feeService.AddFee(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: CustomerController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditInventory")]
        public void Edit(int id, Fee model)
        {
            try
            {
                feeService.UpdateFee(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CustomerController/Delete/5
        [HttpGet]
        [Route("InventoryDelete")]
        public string Delete(int id)
        {
            feeService.DeleteFee(id);

            return "Deleted Record Successfully";
        }

    }
}
