using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interface;

namespace SVServices.Implementation
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository) 
        {
            _productoRepository = productoRepository;
        }
        public async Task<List<Producto>> GetProduct(string search = "")
        {
           return await _productoRepository.GetProduct(search);
        }
        public async Task<string> CreateProduct(Producto objeto)
        {
            return await _productoRepository.CreateProduct(objeto);
        }

        public async Task<string> EditProduct(Producto objeto)
        {
            return await _productoRepository.EditProduct(objeto);
        }
    }
}
