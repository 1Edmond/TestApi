using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
	[Route("Commandes")]
	[ApiController]
	public class CommandeController : BaseCRUD<Commande>
	{
		[HttpGet("test")]
		public async Task<IActionResult> Test()
		{
			await Task.Delay(2000);
			return Ok("Méthode spécifique de commande");
		}
	}
}
