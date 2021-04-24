using Microsoft.AspNetCore.Mvc;

namespace EFCore.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		[HttpGet]
		public IActionResult Books()
		{
			return Ok();
		}
	}
}
