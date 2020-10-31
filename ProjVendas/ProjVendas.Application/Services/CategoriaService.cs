using AutoMapper;
using ProjVendas.Application.Interfaces;
using ProjVendas.Application.ViewModels;
using ProjVendas.Domain.Entities;
using ProjVendas.Domain.Interfaces;

namespace ProjVendas.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        public IUnitOfWork _uow;
        public IMapper _mapper;

        public CategoriaService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CategoriaListViewModel Get()
        {
            return new CategoriaListViewModel()
            {
                Categorias = this._uow.CategoriaRepository.Get()
            };
        }

        public CategoriaViewModel Get(int id)
        {
            var Categoria = this._uow.CategoriaRepository.GetById(a => a.CategoriaID == id);
            return _mapper.Map<CategoriaViewModel>(Categoria);
        }

        public CategoriaViewModel Post(CategoriaViewModel CategoriaViewModel)
        {
            var Categoria = _mapper.Map<Categoria>(CategoriaViewModel);

            _uow.CategoriaRepository.Add(Categoria);
            _uow.Commit();

            return _mapper.Map<CategoriaViewModel>(Categoria);
        }

        public CategoriaViewModel Put(int id, CategoriaViewModel CategoriaViewModel)
        {
            var Categoria = _mapper.Map<Categoria>(CategoriaViewModel);

            _uow.CategoriaRepository.Update(Categoria);
            _uow.Commit();

            return _mapper.Map<CategoriaViewModel>(Categoria);
        }

        public CategoriaViewModel Delete(int id)
        {
            var Categoria = this._uow.CategoriaRepository.GetById(a => a.CategoriaID == id);

            if (Categoria == null)
            {
                return null;
            }

            _uow.CategoriaRepository.Delete(Categoria);
            _uow.Commit();

            return _mapper.Map<CategoriaViewModel>(Categoria);
        }
    }
}