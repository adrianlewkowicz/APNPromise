using System.Threading.Tasks;
using Applications.Commands;
using Applications.DTOs;
using Applications.Queries;
using Microsoft.AspNetCore.Mvc;

namespace APN_Promise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookQueryService _bookQueryService;
        private readonly IBookCommandService _bookCommandService;

        public BooksController(IBookQueryService bookQueryService, IBookCommandService bookCommandService)
        {
            _bookQueryService = bookQueryService;
            _bookCommandService = bookCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            string bearerToken = "YourBearerToken";

            var books = await _bookQueryService.GetBooksAsync(bearerToken);
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> PostBook([FromBody] BookDto book)
        {
            string bearerToken = "YourBearerToken";

            try
            {
                await _bookCommandService.PostBookAsync(book, bearerToken);
                return Ok("Book added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add book: {ex.Message}");
            }
        }
    }
}
