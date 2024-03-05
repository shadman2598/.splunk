using Microsoft.AspNetCore.Mvc;

[Route("api/books")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBooks()
    {
        return Ok(Storage.Books);
    }

    [HttpGet("{id}")]
    public IActionResult GetBook(int id)
    {
        var book = Storage.Books.Find(b => b.Id == id);
        if (book == null) return NotFound();
        return Ok(book);
    }

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        book.Id = Storage.Books.Count + 1;
        Storage.Books.Add(book);
        return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book bookUpdate)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var book = Storage.Books.Find(b => b.Id == id);
        if (book == null) return NotFound();
        book.Title = bookUpdate.Title;
        book.Author = bookUpdate.Author;
        book.IsAvailable = bookUpdate.IsAvailable;
        return Ok(book);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = Storage.Books.Find(b => b.Id == id);
        if (book == null) return NotFound();
        Storage.Books.Remove(book);
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