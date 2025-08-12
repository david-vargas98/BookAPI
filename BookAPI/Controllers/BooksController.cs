using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    // It'll look like: https://localhost:7050/api/books
    [Route("api/[Controller]")] // Route attribute defines the base route for the controller
    [ApiController] // ApiController attribute is used to indicate that this controller responds to web API requests and gives us more functionalities
    public class BooksController : ControllerBase // ControllerBase is used for APIs since angular will handle the views
    {
        // Mock data for demonstration purposes
        private Book[] _books = new Book[] // using underscore is a common convention to indicate a private field
        {
            new Book { Id = 1, Author= "Author One", Title= "Book One" },
            new Book { Id = 2, Author= "Author Two", Title= "Book Two" },
            new Book { Id = 3, Author= "Author Three", Title= "Book Three" }
        };

        [HttpGet] // This attribute indicates that this method responds to GET requests
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books); // Returns a 200 OK response with the list of books
        }
    }
}
