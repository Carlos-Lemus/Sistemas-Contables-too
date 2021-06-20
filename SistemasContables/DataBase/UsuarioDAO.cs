using SistemasContables.Models;
using SistemasContables.Utilitys;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class UsuarioDAO : DAO
    {      
        private List<Usuario> listaUsers;

        public UsuarioDAO ()
        {
            listaUsers = new List<Usuario>();
        }

        public List<Usuario> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIOS}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaUsers.Count > 0)
                        {
                            listaUsers.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Usuario user = new Usuario();

                                user.IdUsuario = Convert.ToInt32(result[ID_USUARIO].ToString());
                                user.NombreUsuario = result[NOMBRE_USUARIO].ToString();
                                user.Rol = result[ROL_USUARIO].ToString();
                                user. Password = result[PASSWORD_USUARIO].ToString();

                                listaUsers.Add(user);
                            }
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaUsers;
        }

        public Usuario searchUser(int idUsuario)
        {
            Usuario user = new Usuario();
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIOS} WHERE {ID_USUARIO} = {idUsuario}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                user.IdUsuario = Convert.ToInt32(result[ID_USUARIO].ToString());
                                user.NombreUsuario = result[NOMBRE_USUARIO].ToString();
                                user.Rol = result[ROL_USUARIO].ToString();
                                user.Password = result[PASSWORD_USUARIO].ToString();
                            }
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return user;
        }

        public bool insert(Usuario user)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_USUARIOS} ({ID_USUARIO}, {NOMBRE_USUARIO}, {ROL_USUARIO}, {PASSWORD_USUARIO}) VALUES(NULL, @{NOMBRE_USUARIO}, @{ROL_USUARIO}, @{PASSWORD_USUARIO})";                    

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRE_USUARIO}", user.NombreUsuario);
                    command.Parameters.AddWithValue($"@{ROL_USUARIO}", user.Rol);                    
                    command.Parameters.AddWithValue($"@{PASSWORD_USUARIO}", Encrypt.GetSHA256(user.Password));                    
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool update(Usuario user)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_USUARIOS} SET {NOMBRE_USUARIO} = @{NOMBRE_USUARIO}, {ROL_USUARIO} = @{ROL_USUARIO} WHERE {ID_USUARIO} = @{ID_USUARIO};";

                    string ePassword = "";

                    command.Connection = Conexion.Conn;
                    command.CommandText = sql;

                    if (!String.IsNullOrEmpty(user.Password))
                    {
                        ePassword = Encrypt.GetSHA256(user.Password);

                        sql = $"UPDATE {TABLE_USUARIOS} SET {NOMBRE_USUARIO} = @{NOMBRE_USUARIO}, {ROL_USUARIO} = @{ROL_USUARIO}, {PASSWORD_USUARIO} = @{PASSWORD_USUARIO} WHERE {ID_USUARIO} = @{ID_USUARIO};";
                        
                        command.CommandText = sql;
                        command.Parameters.AddWithValue($"@{PASSWORD_USUARIO}", ePassword);
                    }
                
                    command.Parameters.AddWithValue($"@{NOMBRE_USUARIO}", user.NombreUsuario);
                    command.Parameters.AddWithValue($"@{ROL_USUARIO}", user.Rol);
                    command.Parameters.AddWithValue($"@{ID_USUARIO}", user.IdUsuario);                   
                    
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool delete(int idUsuario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();               

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_USUARIOS} WHERE {ID_USUARIO} = @{ID_USUARIO};";

                    command.CommandText = sql;
                    command.Parameters.AddWithValue($"@{ID_USUARIO}", idUsuario);
                    command.Connection = Conexion.Conn;                    
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public Usuario verifyUser(string nombre, string password)
        {

            Usuario user = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIOS} WHERE {NOMBRE_USUARIO} = @{NOMBRE_USUARIO} AND {PASSWORD_USUARIO} = @{PASSWORD_USUARIO}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NOMBRE_USUARIO}", nombre);
                    command.Parameters.AddWithValue($"@{PASSWORD_USUARIO}", password);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                user = new Usuario();

                                user.IdUsuario = Convert.ToInt32(result[ID_USUARIO].ToString());
                                user.NombreUsuario= result[NOMBRE_USUARIO].ToString();
                                user.Rol  = result[ROL_USUARIO].ToString();

                     
                            }
                        }
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return user;
        }

    }
}
