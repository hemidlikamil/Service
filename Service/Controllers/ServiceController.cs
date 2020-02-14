using System;
using System.Web.Http;

namespace Service.Controllers
{
    public class ServiceController : ApiController
    {
        public IHttpActionResult Get(string value)
        {
            var arr = value.ToCharArray();
            Array.Reverse(arr);
            return Ok(new string(arr));
        }
    }
}