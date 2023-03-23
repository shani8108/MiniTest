using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectEntities;
using ProjectModel;

namespace ProjectUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityPerUnitController : ControllerBase
    {
        public QuantityUnitEntities quantityUnitEntities { get; set; }
        public QuantityPerUnitController()
        {
            quantityUnitEntities = new QuantityUnitEntities();
        }
        // GET: api/<QuantityPerUnitController>
        [HttpGet("GetQuantityPerUnit")]
        public JsonResult GetQuantityPerUnit()
        {
            List<QuantityPerUnit> table = quantityUnitEntities.GetQuantityPerUnitE();

            return new JsonResult(table);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("GetQuantityOfUnit")]
        public JsonResult GetQuantityOfUnit()
        {
            List<QuantityPerUnit> table = quantityUnitEntities.GetQuantityOfUnitE();
            return new JsonResult(table);
        }

        /* POST api/<DepartmentController>
        [HttpPost]
        public JsonResult Post([FromBody] Department dep)
        {
            string res = departmentEntities.InsertDepartmentE(dep);
            return new JsonResult(res);
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] Department dep)
        {
            string res = departmentEntities.UpdateDepartmentE(id, dep);
            return new JsonResult(res);
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string res = departmentEntities.DeleteDepartmentE(id);
            return new JsonResult(res);
        }
        */
    }
}
