using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyFirstTestAPI.Controllers
{
    [Route("jokes")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        // GET jokes/
        [HttpGet]
        public async Task<ActionResult<string>>  Get()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept","text/plain");
            HttpResponseMessage response = await client.GetAsync("https://icanhazdadjoke.com/");
           
            return await response.Content.ReadAsStringAsync();
        }

        //// GET jokes/5
        //[HttpGet("{id}")]
        //public async Task <ActionResult<string>> Get(string id)
        //{
        //    var client = new HttpClient();
        //    //client.DefaultRequestHeaders
        //    HttpResponseMessage response = await client.GetAsync($"https://icanhazdadjoke.com/j/{id}");
        //    return await response.Content.ReadAsStringAsync();
        //}

        // GET jokes/search
        // Let's you specify a searchterm in the URL
        [HttpGet("{searchTerm}")]
        public async Task<ActionResult<string>> Get(string searchTerm)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept","text/plain");
            HttpResponseMessage response = await client.GetAsync($"https://icanhazdadjoke.com/search?term={searchTerm}");

            return await response.Content.ReadAsStringAsync();
        
        }


    }
}
