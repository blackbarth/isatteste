using AutoMapper;

namespace Questao2.AutoMapper
{

    public class AutoMapperConfig
    {
        public static MapperConfiguration Mapper { get; private set; }
        public static void RegisterMappings()
        {
            AutoMapperConfig.Mapper = new MapperConfiguration((mapper) =>
            {
                mapper.AddProfile<DomainToViewModelMappingProfile>();
                mapper.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}