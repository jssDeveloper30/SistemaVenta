using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;

namespace SVRepository.Implementation
{
    public class ProductoRepository(Conexion conexion) : IProductoRepository
    {
        private readonly Conexion _conexion = conexion;

        public async Task<List<Producto>> GetProduct(string search = "")
        {
            List<Producto> list = [];

            using var con = _conexion.GetConexion();
            con.Open();
            var cmd = new SqlCommand("sp_listaProducto", con);
            cmd.Parameters.AddWithValue("@Buscar", search);
            cmd.CommandType = CommandType.StoredProcedure;

            using (var dr = await cmd.ExecuteReaderAsync())
            {
                while (await dr.ReadAsync())
                {
                    list.Add(new Producto
                    {
                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                        RefCategoria = new Categoria
                        {
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            Nombre = dr["NombreCategoria"].ToString()
                        },
                        Codigo = dr["Codigo"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                        PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        Activo = Convert.ToInt32(dr["Activo"])
                    });
                }
            }
            return list;
        }
        public async Task<string> CreateProduct(Producto objeto)
        {
            string response = "";

            using var con = _conexion.GetConexion();

            con.Open();

            var cmd = new SqlCommand("sp_crearProducto", con);
            cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
            cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
            cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
            cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                await cmd.ExecuteNonQueryAsync();
                response = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
            }
            catch
            {
                response = "Error(rp): No se pudo procesar";
            }
            return response;
        }
        public async Task<string> EditProduct(Producto objeto)
        {
            string response = "";

            using var con = _conexion.GetConexion();

            con.Open();
            var cmd = new SqlCommand("sp_editarProducto", con);
            cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
            cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
            cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
            cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
            cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
            cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                await cmd.ExecuteNonQueryAsync();
                response = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
            }
            catch
            {
                response = "Error(rp): No se pudo procesar";
            }
            return response;
        }
    }
}
