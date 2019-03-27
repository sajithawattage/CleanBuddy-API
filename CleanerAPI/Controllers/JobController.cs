using Cleaner.Business;
using Cleaner.Model;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    public class JobController : BaseController
    {
        IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetJobList()
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
