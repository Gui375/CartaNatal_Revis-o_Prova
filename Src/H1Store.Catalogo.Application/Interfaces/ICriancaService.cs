using H1Store.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Interfaces
{
	public interface ICriancaService
	{
		public Task<IEnumerable<CriancaViewModel>> ObterTodos();
		public Task Adicionar(NovaCriancaViewModel carta);
	}
}
