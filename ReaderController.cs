using Microsoft.AspNetCore.Mvc;

[Route("api/readers")]
[ApiController]
public class ReaderController : ControllerBase
{
    [HttpGet]
    public IActionResult GetReaders()
    {
        return Ok(Storage.Readers);
    }

    [HttpGet("{id}")]
    public IActionResult GetReader(int id)
    {
        var reader = Storage.Readers.Find(r => r.Id == id);
        if (reader == null) return NotFound();
        return Ok(reader);
    }

    [HttpPost]
    public IActionResult AddReader([FromBody] Reader reader)
    {
        reader.Id = Storage.Readers.Count + 1;
        Storage.Readers.Add(reader);
        return CreatedAtAction(nameof(GetReader), new { id = reader.Id }, reader);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateReader(int id, [FromBody] Reader readerUpdate)
    {
        var reader = Storage.Readers.Find(r => r.Id == id);
        if (reader == null) return NotFound();
        reader.Name = readerUpdate.Name;
        return Ok(reader);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteReader(int id)
    {
        var reader = Storage.Readers.Find(r => r.Id == id);
        if (reader == null) return NotFound();
        Storage.Readers.Remove(reader);
        return NoContent();
    }

        [HttpGet("health")] // New endpoint for health check and new route "kind of" api/books/health
    public IActionResult Health()
    {
        return Ok();
    }

    [HttpGet("whereami")] 
    public IActionResult WhereAmI()
    {
        return Ok("BookController");
    }

    [HttpGet("osinfo")]
    public IActionResult OSInfo()
    {
        return Ok(Environment.OSVersion.ToString());
    }

    [HttpGet("browserinfo")]
    public IActionResult BrowserInfo()
    {
        return Ok(Request.Headers["User-Agent"]);
    }

    [HttpGet("ipinfo")]
    public IActionResult IPInfo()
    {
        return Ok("localhost!");
    }
}