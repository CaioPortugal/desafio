using AutoMapper;
using desafio.dados;
using desafio_back.Helpers;
using desafio_back.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace desafio_back.Controllers
{
    public class AnuncioController : ApiController
    {
        private IRepository<Anuncio> repository;
        private IMapper mapper;
        public AnuncioController(IRepository<Anuncio> repo)
        {
            repository = repo;
            mapper =  AutoMapperHelper.MapperConfiguration;
        }

        /// <summary>
        /// Listagem de todos os anúncios cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AnuncioResponse> Get()
        {
            return mapper.Map<IEnumerable<Anuncio>,
                              IEnumerable<AnuncioResponse>>(repository.GetAll());
        }

        /// <summary>
        /// Obter um anúncio dado o seu código de identificação
        /// </summary>
        /// <param name="id">Código do anúncio</param>
        /// <returns>Anúncio requisitado no sistema</returns>
        public AnuncioResponse Get(int id)
        {
            var anuncio = repository.GetById(id);           
            return mapper.Map<AnuncioResponse>(anuncio);
        }

        /// <summary>
        /// Criação dos anúncios
        /// </summary>
        /// <param name="anuncioRequest"></param>
        public HttpResponseMessage Post([FromBody]AnuncioRequest anuncioRequest)
        {
            if (!ModelState.IsValid)        
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        
            repository.Insert(mapper.Map<Anuncio>(anuncioRequest));
            repository.Save();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }


        /// <summary>
        /// Alteração dos dados do anúncio
        /// </summary>
        /// <param name="id">Código de identificação do anúncio</param>
        /// <param name="anuncioRequest">Dados do anúncio</param>
        public HttpResponseMessage Put(int id, [FromBody]AnuncioRequest anuncioRequest)
        {
            var anuncio = repository.GetById(id);
            if (anuncio == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

            mapper.Map(anuncioRequest,anuncio);
            repository.Update(anuncio);
            repository.Save();
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        /// <summary>
        /// Remoção do anúncio baseado no seu código de identificação
        /// </summary>
        /// <param name="id">Código de identificação do anúncio</param>
        public HttpResponseMessage Delete(int id)
        {
            var anuncio = repository.GetById(id);
            if (anuncio == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
           
            repository.Delete(id);
            repository.Save();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
