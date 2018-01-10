using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DATC_API.Controllers
{
    public class MobileController : ApiController
    {
        // GET: api/Mobile
        public IEnumerable<string> Get()
        {

            //  citesc din BD ..din cea cu 2 campuri .... si returnez o lista pentru aplicatia mobila
            return new string[] { "value1", "value2" };
        }

        // GET: api/Mobile/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mobile
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mobile/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mobile/5
        public void Delete(int id)
        {
        }
    }
}
