using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetCategory(string search ="");
        Task<string> CreateCategory(Categoria objeto);
        Task<string> EditCategory(Categoria objeto);
    }
}
