using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interface;

namespace SVServices.Implementation
{
    public class MedidaService : IMedidaService
    {
        private readonly IMedidaRepository _medidaRepository;

        public MedidaService(IMedidaRepository medidaRepository)
        {
            _medidaRepository = medidaRepository;
        }
        public async Task<List<Medida>> GetListSize()
        {
            return await _medidaRepository.GetListSize();
        }
    }
}
