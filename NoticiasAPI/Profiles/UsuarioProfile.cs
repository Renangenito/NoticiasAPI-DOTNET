using AutoMapper;
using NoticiasAPI.Data.Dtos;
using NoticiasAPI.Models;

namespace NoticiasAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
