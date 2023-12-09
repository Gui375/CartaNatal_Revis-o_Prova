using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<CriancaViewModel, Crianca>()
			   .ConstructUsing
			   (q => new Crianca(
				q.CartaId,
				q.NomeCrianca, 
				q.Idade, 
				q.Rua, 
				q.Bairro, 
				q.Cidade, 
				q.Estado, 
				q.Numero, 
				q.TextoCarta));

            CreateMap<NovaCriancaViewModel, Crianca>()
               .ConstructUsing
               (q => new Crianca(
                q.NomeCrianca,
                q.Idade,
                q.Rua,
                q.Bairro,
                q.Cidade,
                q.Estado,
                q.Numero,
                q.TextoCarta));

        }
	}
}
