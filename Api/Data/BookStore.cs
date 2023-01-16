using Api.Models.Dto;

namespace Api.Data
{
	public static class BookStore
	{
		public static List<BookDTO> bookList = new List<BookDTO>
		{
			new BookDTO { Id = 1, Title = "Harry Potter"},
			new BookDTO { Id = 2, Title = "Idai"}
		};
	}
}
