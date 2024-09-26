using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> GetProduct(string search = "");
        Task<string> CreateProduct(Producto objeto);
        Task<string> EditProduct(Producto objeto);
    }
}
