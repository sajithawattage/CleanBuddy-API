using Cleaner.Business;
using Cleaner.Model;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/equipment")]
    public class EquipmentController : BaseController
    {
        private readonly IEquipmentService _equipementService;
            
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipementService = equipmentService;
        }

        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetEquipmentList()
        {
            var list = _equipementService.GetEquipmentList();
            return Ok(list);
        }
        
        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetEquipmentById(int id)
        {
            var equipment = _equipementService.GetEquipmentById(id);
            return Ok(equipment);
        }
        
        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveEquipment([FromBody] Equipment eqiupment)
        {
            try
            {
                _equipementService.SaveEquipment(eqiupment);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateEquipment([FromBody] Equipment eqiupment)
        {
            try
            {
                _equipementService.UpdateEquipment(eqiupment);
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
            var result = _equipementService.DeleteEquipment(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
