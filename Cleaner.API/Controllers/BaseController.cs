using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace Cleaner.API.Controllers
{
    [Authorize]
    public class BaseController : ApiController
    {
    }
}
