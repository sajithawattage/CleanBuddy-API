using Cleaner.Business;
using Cleaner.DataAccess;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/employee")]
    public class EmployeeController : BaseController
    {
        IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IHttpActionResult> GetEmployeeList()
        {
            var list = _employeeService.GetEmployeeList();
            return Ok(list);
        }
        
        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var equipment = _employeeService.GetEmployeeById(id);
            return Ok(equipment);
        }
        
        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveEmployee([FromBody] Employee employee)
        {
            try
            {
                _employeeService.SaveEmployee(employee);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateEmployee([FromBody] Employee employee)
        {
            try
            {
                _employeeService.UpdateEmployee(employee);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult RemoveEquipments(int id)
        {
            var result = _employeeService.DeleteEmployee(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }

    }
}
