

using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{ Id=1, Author="Sammy kenzo",Title="The Power of hacking"},
            new Book{ Id=2, Author="Ken kenzo",Title="The Power wining women"},
            new Book{ Id=3, Author="Diana kenzo",Title="The Power wining men"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {    
            return Ok(_books);
        }
    }
}
