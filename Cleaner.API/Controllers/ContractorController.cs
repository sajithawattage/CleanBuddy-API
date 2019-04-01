using Cleaner.Business;
using Cleaner.Model;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    public class ContractorController : BaseController
    {
        IContractorService _contractorService;

        public ContractorController(IContractorService contractorService)
        {
            _contractorService = contractorService;
        }

        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetContractorList()
        {
            var list = _contractorService.GetContractorList();
            return Ok(list);
        }
        
        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetContractorById(int id)
        {
            var equipment = _contractorService.GetContractorById(id);
            return Ok(equipment);
        }
        
        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveContractor([FromBody] Contractor contractor)
        {
            try
            {
                _contractorService.SaveContractor(contractor);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateContractor([FromBody] Contractor contractor)
        {
            try
            {
                _contractorService.UpdateContractor(contractor);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteContractor(int id)
        {
            var result = _contractorService.DeleteContractor(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
