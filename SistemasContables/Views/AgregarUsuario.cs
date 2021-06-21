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
    public partial class AgregarUsuario : Form
    {
        private Usuario user;
        private UsuarioDAO usuarioDao;
        public AgregarUsuario(bool isEdit, int id = 0)
        {
            InitializeComponent();
            usuarioDao = new UsuarioDAO();
            user = new Usuario();
            this.user.IdUsuario = id;
            btnEditarUser.Visible = false;
            comboTipo.SelectedItem = "Administrador";
            this.user.Rol = comboTipo.SelectedItem.ToString();            

            if (isEdit)
            {
                this.user = this.usuarioDao.searchUser(this.user.IdUsuario);
                txtNombreUSer.Text = this.user.NombreUsuario;
                comboTipo.SelectedItem = this.user.Rol;
                btnGuardarUser.Visible = false;
                btnEditarUser.Visible = true;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            this.user.NombreUsuario = txtNombreUSer.Text;
            this.user.Password = txtContraUser.Text;
            this.usuarioDao.update(this.user);
            this.Close();
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            this.user.NombreUsuario = txtNombreUSer.Text;
            this.user.Password = txtContraUser.Text;

            this.usuarioDao.insert(this.user);

            this.Close();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.user.Rol = comboTipo.SelectedItem.ToString();
        }
    }
}
