using Microsoft.Extensions.DependencyInjection;
using SVServices.Implementation;
using SVServices.Interface;

namespace SVServices
{
    public static class DependecyInjection
    {
        public static void RegisterServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
        }
    }
}
