using AutoMapper;
using desafio.dados;
using desafio_back.Models;

namespace desafio_back.Helpers
{
    public class AutoMapperHelper 
    {
        public static IMapper MapperConfiguration
        {
            get
            {
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Anuncio, AnuncioResponse>();
                    cfg.CreateMap<AnuncioResponse, Anuncio>();
                    cfg.CreateMap<AnuncioRequest, Anuncio>();
                    cfg.CreateMap<Anuncio, AnuncioRequest>();
                }
               );
                return configuration.CreateMapper();
            }
        }
    }
}