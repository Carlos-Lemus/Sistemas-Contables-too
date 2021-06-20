using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class UsuariosForm : Form
    {
        private UsuarioDAO userDao;
        private List<Usuario> listaUsers;
        public UsuariosForm()
        {
            InitializeComponent();
            userDao = new UsuarioDAO();
            cargarDatos();
        }     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Parent.Visible = false;
            
            using (AgregarUsuario form = new AgregarUsuario(false))
            {
                form.ShowDialog();
            }

            this.Parent.Parent.Parent.Visible = true;

            cargarDatos();
        }

        private void dvgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dvgUsuarios.Columns[e.ColumnIndex].Name == "editarColumna")
            {
                this.Parent.Parent.Parent.Visible = false;
            
                string id = dvgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                using (AgregarUsuario form = new AgregarUsuario(true, Int32.Parse(id)))
                {
                    form.ShowDialog();
                }
            
                cargarDatos();
            
                this.Parent.Parent.Parent.Visible = true;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = dvgUsuarios.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        userDao.delete(Convert.ToInt32(row.Cells[0].Value));

                        cargarDatos();
                    }

                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var listaSearch = listaUsers.Where(user=> user.NombreUsuario.ToLower().Contains(txtSearch.Text.ToLower()));

            cargarDatosSearch(listaSearch.ToList());
        }

        private void cargarDatos()
        {
            if (dvgUsuarios.RowCount > 0)
            {
                dvgUsuarios.Rows.Clear();
                listaUsers.Clear();
            }

            listaUsers = userDao.getList();

            lblUsers.Text = "Numero de usuarios registrados: " + listaUsers.Count;

            foreach (Usuario user in listaUsers)
            {
                dvgUsuarios.Rows.Add(user.IdUsuario, user.NombreUsuario, user.Rol, user. Password);
            }
        }

        private void cargarDatosSearch(List<Usuario> lista)
        {
            if (dvgUsuarios.RowCount > 0)
            {
                dvgUsuarios.Rows.Clear();
            }

            foreach (Usuario user in lista)
            {
                dvgUsuarios.Rows.Add(user.IdUsuario, user.NombreUsuario, user.Rol, user.Password);
            }
        }
    }
}
