using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WinServiceWithOwin.API
{

    [RoutePrefix("api/services")]
    public class ServicesController : ApiController
    {
        [HttpGet]
        [Route("GetAliveStatus")]
        public bool GetAliveStatus()
        {
            return true;
        }
    }
}
