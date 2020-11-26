using AutoMapper;

namespace VeiculosAPI.Entities{
    public class DefaultMapper : Profile{
        public DefaultMapper(){
            CreateMap<Moto, MotoVO>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}