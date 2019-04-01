using Cleaner.Business;
using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cleaner.API.Controllers
{
    [RoutePrefix("approvegroup")]
    public class ApproveGroupController : BaseController
    {
        IApproveGroupService _approveGroupService;

        public ApproveGroupController(IApproveGroupService approveGroupService)
        {
            _approveGroupService = approveGroupService;
        }

        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetApproveGroupList()
        {
            var list = _approveGroupService.GetApproveGroupList();
            return Ok(list);
        }


        [HttpGet]
        [Route("items/{id:int}")]
        public IHttpActionResult GetApproveGroupById(int id)
        {
            var equipment = _approveGroupService.GetApproveGroupById(id);
            return Ok();
        }


        [HttpPost]
        [Route("items")]
        public IHttpActionResult SaveApproveGroup([FromBody] ApproveGroup approveGroup)
        {
            try
            {
                _approveGroupService.SaveApproveGroup(approveGroup);
                return Ok();
            }
            catch (System.Exception e)
            {
                return InternalServerError(e);
            }

        }

        [HttpPut]
        [Route("items")]
        public IHttpActionResult UpdateAddress([FromBody] ApproveGroup approveGroup)
        {
            try
            {
                _approveGroupService.UpdateApproveGroup(approveGroup);
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
            var result = _approveGroupService.DeleteApproveGroup(id);
            if (result)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
