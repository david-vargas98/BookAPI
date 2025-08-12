using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    // It'll look like: https://localhost:7050/api/books
    [Route("api/[Controller]")] // Route attribute defines the base route for the controller
    [ApiController] // ApiController attribute is used to indicate that this controller responds to web API requests and gives us more functionalities
    public class BooksController : ControllerBase // ControllerBase is used for APIs since angular will handle the views
    {

    }
}
