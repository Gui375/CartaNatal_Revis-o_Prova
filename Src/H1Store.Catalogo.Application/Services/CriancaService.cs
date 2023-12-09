using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
	public class CriancaService : ICriancaService
	{
		#region - Construtores

		private readonly ICriancaRepository _cartaRepository;
		private readonly IMapper _mapper;

        public CriancaService(ICriancaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções
        public async Task Adicionar(NovaCriancaViewModel novaCartaViewModel)
		{
			var novaCarta = _mapper.Map<Crianca>(novaCartaViewModel);
			await _cartaRepository.Adicionar(novaCarta);

		}

		public async Task<IEnumerable<CriancaViewModel>> ObterTodos()
		{
			var cartas = await _cartaRepository.ObterTodos();

            return _mapper.Map<IEnumerable<CriancaViewModel>>(cartas);
		}
		#endregion
	}
}
