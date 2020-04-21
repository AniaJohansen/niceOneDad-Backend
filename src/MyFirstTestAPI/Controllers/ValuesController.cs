using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstTestAPI.Controllers
{
    [Route("values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET values/
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value " + $"{id + 3}";
        }

        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return "Name requested is" + $"{name}";
        }

        // POST values/
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
