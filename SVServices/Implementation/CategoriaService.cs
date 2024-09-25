using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interface;

namespace SVServices.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public async Task<List<Categoria>> GetCategory(string buscar = "")
        {
            return await _categoriaRepository.GetCategory(buscar);
        }
        public async Task<string> CreateCategory(Categoria objeto)
        {
            return await _categoriaRepository.CreateCategory(objeto);
        }

        public async Task<string> EditCategory(Categoria objeto)
        {
            return await _categoriaRepository.EditCategory(objeto);
        }
    }
}
