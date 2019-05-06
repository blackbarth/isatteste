using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalProg.Domain.Entities;
using AnalProg.MVC5.ViewModels;
using AutoMapper;

namespace AnalProg.MVC5.AutoMapper
{

    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }

}