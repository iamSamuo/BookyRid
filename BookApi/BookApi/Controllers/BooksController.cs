

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
            new Book{ Id=1, Author="George Orwell", Title="1984"},
            new Book{ Id=2, Author="Harper Lee", Title="To Kill a Mockingbird"},
            new Book{ Id=3, Author="F. Scott Fitzgerald", Title="The Great Gatsby"},
            new Book{ Id=4, Author="J.K. Rowling", Title="Harry Potter and the Sorcerer's Stone"},
            new Book{ Id=5, Author="J.R.R. Tolkien", Title="The Lord of the Rings"},
            new Book{ Id=6, Author="Jane Austen", Title="Pride and Prejudice"}
        };
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {    
            return Ok(_books);
        }
    }
}
