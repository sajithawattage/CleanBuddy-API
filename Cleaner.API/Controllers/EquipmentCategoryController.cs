using Cleaner.Business;
using Cleaner.DataAccess;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/equipcategory")]
    public class EquipmentCategoryController : BaseController
    {
        private readonly IEquipmentCategoryService _equipementCategoryService;

        public EquipmentCategoryController(IEquipmentCategoryService equipementCategoryService)
        {
            _equipementCategoryService = equipementCategoryService;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IHttpActionResult> GetEquipmentCategoryList()
        {
            throw new NotSupportedException();
        }


        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetEquipmentCategoryById(int id)
        {
            var equipment = _equipementCategoryService.GetEquipmentCategoryById(id);
            return Ok(equipment);
        }


        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveEquipment([FromBody] EquipmentCategory eqiupment)
        {
            try
            {
                _equipementCategoryService.SaveEquipmentCategory(eqiupment);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateEquipment([FromBody] EquipmentCategory eqiupment)
        {
            try
            {
                _equipementCategoryService.UpdateEquipmentCategory(eqiupment);
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
            var result = _equipementCategoryService.DeleteEquipmentCategory(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
