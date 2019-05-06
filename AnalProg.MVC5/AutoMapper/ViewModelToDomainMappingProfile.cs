using AnalProg.Domain.Entities;
using AnalProg.MVC5.ViewModels;
using AutoMapper;

namespace AnalProg.MVC5.AutoMapper
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }

}