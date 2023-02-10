using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

public class BaseCRUD<T> : ControllerBase
{
	[HttpGet($"add")]
	public IActionResult AddElement() => Ok($"Classe mère {typeof(T).Name}");
	

}
