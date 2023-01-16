using Api.Data;
using Api.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/Book")]
	[ApiController]
	public class BookController : ControllerBase
	{
		[HttpGet]
		[ProducesResponseType(200)]
		public ActionResult<IEnumerable<BookDTO>> GetBooks()
		{
			return Ok(BookStore.bookList);
		}

		[HttpGet("{id:int}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(404)]
		[ProducesResponseType(400)]
		public ActionResult<BookDTO> GetBook(int id)
		{
			if (id == 0) { return BadRequest(); }

			var book = BookStore.bookList.FirstOrDefault(book => book.Id == id);

			if (book == null) { return NotFound(); }

			return Ok(book);
		}
	}
}
