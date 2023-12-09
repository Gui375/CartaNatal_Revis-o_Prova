using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CriancaController : ControllerBase
	{
		private readonly ICriancaService _cartaService;

		public CriancaController(ICriancaService cartaService)
		{
			_cartaService = cartaService;
		}

		[HttpPost(Name = "Adicionar")]
		public async Task<IActionResult> Post(NovaCriancaViewModel novaCartaViewModel)
		{
			await _cartaService.Adicionar(novaCartaViewModel);

			return Ok();
		}


		[HttpGet(Name = "ObterTodos")]
		public async Task<IActionResult> Get()
		{
			var cartas = await _cartaService.ObterTodos();

            return Ok(cartas);
		}
	}
}
