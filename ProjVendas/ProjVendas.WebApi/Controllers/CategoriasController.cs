using Microsoft.AspNetCore.Mvc;
using ProjVendas.Application.Interfaces;
using ProjVendas.Application.ViewModels;

namespace ProjVendas.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CategoriasController  : ControllerBase
    {
        private ICategoriaService _CategoriaService;

        public CategoriasController(ICategoriaService CategoriaService)
        {
            this._CategoriaService = CategoriaService;
        }

        [HttpGet]
        public CategoriaListViewModel Get()
        {
            return _CategoriaService.Get();
        }

        [HttpGet("{id}", Name="GetDetails")]
        public ActionResult<CategoriaViewModel> Get(int id) 
        { 
            var result = _CategoriaService.Get(id);

            if (result == null)
                return NotFound();

            return _CategoriaService.Get(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CategoriaViewModel Categoria)
        {
            var result = _CategoriaService.Post(Categoria);

            return new CreatedAtRouteResult("GetDetails", 
                new { id = result.Id}, result);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CategoriaViewModel CategoriaViewModel)
        {
            if (id != CategoriaViewModel.Id)
            {
                return BadRequest();
            }

            var result = _CategoriaService.Put(id, CategoriaViewModel);

            return new CreatedAtRouteResult("GetDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<CategoriaViewModel> Delete(int id)
        {
            var result = _CategoriaService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}