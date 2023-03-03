using Microsoft.AspNetCore.Mvc;

namespace Musical.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtistsController : ControllerBase
{
    // GET: api/artists
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/artists/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/artists
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/artists/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/artists/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
