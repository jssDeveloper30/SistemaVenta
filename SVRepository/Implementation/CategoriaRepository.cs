using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;

namespace SVRepository.Implementation
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Conexion _conexion;
        public CategoriaRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<List<Categoria>> GetCategory(string buscar = "")
        {
            List<Categoria> list = new List<Categoria>();

            using (var con = _conexion.GetConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaCategoria", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Categoria
                        {
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            Nombre = dr["Nombre"].ToString()!,
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefMedida = new Medida
                            {
                                IdMedida = Convert.ToInt32(dr["IdMedida"]),
                                Nombre = dr["NombreMedida"].ToString()!
                            }
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> CreateCategory(Categoria objeto)
        {
            string response = "";

            using (var con = _conexion.GetConexion())
            {
                con.Open();

                var cmd = new SqlCommand("sp_crearCategoria", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
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
            }
            return response;
        }

        public async Task<string> EditCategory(Categoria objeto)
        {
            string response = "";

            using (var con = _conexion.GetConexion())
            {
                con.Open();
                //                @IdCategoria int,
                //@Nombre varchar(50),
                //@IdMedida int,
                //@Activo int,
                //@MsjError varchar(100) output
                var cmd = new SqlCommand("sp_editarCategoria", con);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
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
            }
            return response;
        }


    }
}
