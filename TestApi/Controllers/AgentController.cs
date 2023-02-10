using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers;

[Route("Agents")]
[ApiController]
public class AgentController : BaseCRUD<Agent>
{
	[HttpGet("test")]
	public async Task<IActionResult> Test([FromQuery] string? search)
	{
		return Ok($"Méthode spécifique d'agent \n {search}");
	}

}
