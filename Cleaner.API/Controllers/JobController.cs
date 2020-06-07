using Cleaner.Business;
using Cleaner.DataAccess;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/job")]
    public class JobController : BaseController
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IHttpActionResult> GetJobList()
        {
            var list = _jobService.GetJobList();
            return Ok(list);
        }


        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetJobEquipmentById(int id)
        {
            var equipment = _jobService.GetJobById(id);
            return Ok(equipment);
        }


        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveEquipment([FromBody] Job job)
        {
            try
            {
                _jobService.SaveJob(job);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateEquipment([FromBody] Job job)
        {
            try
            {
                _jobService.UpdateJob(job);
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
            var result = _jobService.DeleteJob(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
