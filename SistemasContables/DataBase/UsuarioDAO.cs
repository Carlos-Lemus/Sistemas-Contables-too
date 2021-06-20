using SistemasContables.Models;
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

                                user.idUsuario = Convert.ToInt32(result[ID_USUARIO].ToString());
                                user.nombreUsuario = result[NOMBRE_CUENTA].ToString();
                                user.rol = result[ROL_USUARIO].ToString();                                

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
    }
}
