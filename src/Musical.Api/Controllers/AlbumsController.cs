using Microsoft.AspNetCore.Mvc;

namespace Musical.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumsController : ControllerBase
{
    // GET: api/albums
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/albums/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/albums
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/albums/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/albums/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
