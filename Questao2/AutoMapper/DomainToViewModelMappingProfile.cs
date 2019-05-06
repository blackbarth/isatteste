using AnalProg.Domain.Entities;
using AutoMapper;
using Questao2.ViewModels;

namespace Questao2.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<ClienteViewModel, Cliente>();
        //    Mapper.CreateMap<ProdutoViewModel, Produto>();
        //}
    }
}