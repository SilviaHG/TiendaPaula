using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;
using TiendaPaula.Formularios;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Usuarios : Conexion
    {

        public async Task<bool> Verificar_Usuario_Contra(int usuario, string contrasennia)
        {
            bool existe = false;

            DataTable dt = new DataTable();

            using (MySqlConnection connection = establecerConexion())
                try
                {
                    await AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM USERS WHERE IdUser = @IdUser and Password_user = @Password_user", connection);
                    cmd.Parameters.AddWithValue("@IdUser", usuario);
                    cmd.Parameters.AddWithValue("@Password_user", contrasennia);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    existe = dt.Rows.Count > 0;


                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
                finally
                {
                    await cerrarConexion(connection);
                }

            return existe;
        }

        public async Task<DataTable> MostrarTodosUsuarios()
        {
            DataTable MostrarUsuarios = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_USERS", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarUsuarios);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }
            }

            return MostrarUsuarios;
        }

        //Agregamos un nuevo Usuario
        public async void InsertarUsuario(Class_Usuarios usuarios) // agregamos la clase de proveedores
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_USER", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("ID_U", usuarios.Id_Usuario); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("PASSWORD_U", usuarios.Contrasennia_Usuario);
                    mySqlCommand.Parameters.AddWithValue("ESTADO_U", usuarios.Estado_Usuario);

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Usuario: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // eliminamos un usuario
        public async void EliminarUsuario(int idUsuario)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_USER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_U", idUsuario);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Usuario {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        public async void ActualizarUsuario(Class_Usuarios usuarios)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_USER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_U", usuarios.Id_Usuario); // los parametros que pedimos en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("PASSWORD_U", usuarios.Contrasennia_Usuario);
                    cmd.Parameters.AddWithValue("ESTADO_U", usuarios.Estado_Usuario);


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Usuario {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        //verificar si existe un usuario, devuelve si existe o no
        public async Task<bool> ExisteUsuario(int idUsuario)
        {
            bool existe = false;

            DataTable buscarUsuario = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_USER", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_U", idUsuario);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarUsuario);
                    existe = buscarUsuario.Rows.Count > 0;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Usuario: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }

            return existe;
        }

        //mostrar usuario especifico en la tabla
        public async Task<DataTable> obtenerUsuarioEspecifico(int idUsuario)
        {
            DataTable dtUsuario = new DataTable();
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_USER", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_U", idUsuario);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtUsuario);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }
            return dtUsuario;
        }

        //generamos el id de la tabla autoincremental
        public async Task<int> NumeroMaxUsuario()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand("SELECT max(IdUser_table) from USERS;", cnn);
                    object result = cmd.ExecuteScalar(); // ejecutamos la consulta y obtenemos el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        NumMax = Convert.ToInt32(result); // convertimos el resultado a entero
                        NumMax = NumMax + 1; // sumamos un numero mas para que sea el N° de venta
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }

            return NumMax;
        }

        //Se configuro para recordar este usuario

        public async void RecordarUsuario(Class_Recordar_Usuario user)
        {

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_REMEMBER_USER", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("usuario_p", user.NombreUsuario);
                    cmd.Parameters.AddWithValue("passwd_p", user.Passwd);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                }
                finally
                {
                   await cerrarConexion(connection);
                }
            }

        }

        // Se configuro para olvidar este usuario
        public async void OlvidarUsuario()
        {

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_FORGET_USER", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                }
                finally
                {
                    await cerrarConexion(connection);
                }
            }
        }

        /// <summary>
        /// Obtiene el usuario que se recordo del último ingreso
        /// </summary>
        /// <returns>String</returns>
        public async Task<string> UsuarioRecordado()
        {
            string Usuario = "";

            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_GET_USER_REMEMBERED", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Usuario = dataTable.Rows[0][0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                }
                finally
                {
                    await cerrarConexion(connection);
                }
            }

            return Usuario;
        }

        public async Task<string> ContrasenniaRecordada()
        {
            string Pass = "";

            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("sp_GET_PASSWORD_REMEMBERED", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Pass = dataTable.Rows[0][0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error " + ex.Message);
                }
                finally
                {
                    await cerrarConexion(connection);
                }
            }

            return Pass;
        }

        //generamos el id de la tabla autoincremental
        public async Task<string> MostrarUsuarioIngresadoPosicion(int idU)
        {
            string position ="";

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand($"select p.NamePosition " +
                        $"from EMPLOYEES e inner join POSITIONS p " +
                        $"on e.IdPosition = p.IdPosition where IdEmployee = {idU}", cnn);
                    
                    object result = await cmd.ExecuteScalarAsync();

                    //devolvemos la posicion del usuario
                    position = result.ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }
            return position;
        }
        public async Task<string> MostrarUsuarioIngresadoNombre(int idU)
        {
            string nombreUsuario = "";

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand($"select `FullName`" +
                        $" from EMPLOYEES where IdEmployee= {idU}", cnn);

                    object result = await cmd.ExecuteScalarAsync();

                    //devolvemos la posicion del usuario
                    nombreUsuario = result.ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }
            return nombreUsuario;
        }

        public async Task<string> CorreoUsuario(int idU)
        {
            string correoUsuario = "";

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand($"select Email " +
                        $"from EMPLOYEES where IdEmployee = {idU}", cnn);

                    object result = await cmd.ExecuteScalarAsync();

                    //devolvemos el correo del usuario
                    correoUsuario = result.ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }
            return correoUsuario;
        }

        public async Task<string> ContrasenniaUsuario(int idU)
        {
            string contrasenniaUsuario = "";

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand($"select `Password_user` " +
                        $"from USERS where `IdUser` = {idU}", cnn);

                    object result = await cmd.ExecuteScalarAsync();

                    //devolvemos el correo del usuario
                    contrasenniaUsuario = result.ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }
            return contrasenniaUsuario;
        }
    }
}

