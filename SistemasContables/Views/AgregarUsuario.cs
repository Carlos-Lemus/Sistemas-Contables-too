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
        Usuario user;
        private UsuarioDAO usuarioDao;
        public AgregarUsuario(bool isEdit, int id = 0)
        {
            InitializeComponent();
            usuarioDao = new UsuarioDAO();
            user = new Usuario();
            this.user.idUsuario = id;
            btnEditarUser.Visible = false;
            comboTipo.SelectedItem = "Administrador";
            this.user.rol = comboTipo.SelectedItem.ToString();            

            if (isEdit)
            {
                this.user = this.usuarioDao.searchUser(this.user.idUsuario);
                txtNombreUSer.Text = this.user.nombreUsuario;
                txtContraUser.Text = this.user.password;
                comboTipo.SelectedItem = this.user.rol;
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
            this.user.nombreUsuario = txtNombreUSer.Text;
            this.user.password = txtContraUser.Text;
            this.usuarioDao.update(this.user);
            this.Close();
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            this.user.nombreUsuario = txtNombreUSer.Text;
            this.user.password = txtContraUser.Text;

            this.usuarioDao.insert(this.user);

            this.Close();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.user.rol = comboTipo.SelectedItem.ToString();
        }
    }
}
