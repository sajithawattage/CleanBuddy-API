using Cleaner.Business;
using Cleaner.Model;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/jobequipment")]
    public class JobEquipmentController : BaseController
    {
        IJobEquipmentService _jobEquipmentService;

        public JobEquipmentController(IJobEquipmentService jobEquipmentService)
        {
            _jobEquipmentService = jobEquipmentService;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IHttpActionResult> GetJobEquipmentList()
        {
            var list = await _jobEquipmentService.GetJobEquipmentList();
            return Ok(list);
        }


        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetJobEquipmentById(int id)
        {
            var equipment = _jobEquipmentService.GetJobEquipmentById(id);
            return Ok(equipment);
        }


        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveJobEquipment([FromBody] JobEquipment jobEquipment)
        {
            try
            {
                _jobEquipmentService.SaveJobEquipment(jobEquipment);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateJobEquipment([FromBody] JobEquipment jobEquipment)
        {
            try
            {
                _jobEquipmentService.UpdateJobEquipment(jobEquipment);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult RemoveJobEquipment(int id)
        {
            var result = _jobEquipmentService.DeleteJobEquipment(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
