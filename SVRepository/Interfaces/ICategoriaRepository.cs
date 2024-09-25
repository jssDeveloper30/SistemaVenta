using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetCategory(string buscar ="");
        Task<string> CreateCategory(Categoria objeto);
        Task<string> EditCategory(Categoria objeto);
    }
}
