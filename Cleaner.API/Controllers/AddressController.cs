using Cleaner.Business;
using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("v1/address")]
    public class AddressController : ApiController
    {
        IAddressService _addressService;
        
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        [Route("items")]
        public async Task<IHttpActionResult> GetAddressList()
        {
            var list = await _addressService.GetAddressList();
            return Ok(list);
        }


        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetAddressById(int id)
        {
            var equipment = _addressService.GetAddressById(id);
            return Ok();
        }


        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveAddress([FromBody] Address address)
        {
            try
            {
                _addressService.SaveAddress(address);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateAddress([FromBody] Address address)
        {
            try
            {
                _addressService.UpdateAddress(address);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult RemoveAddresss(int id)
        {
            var result = _addressService.DeleteAddress(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }

    }
}
