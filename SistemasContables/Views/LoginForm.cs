using SistemasContables.DataBase;
using SistemasContables.Models;
using SistemasContables.Utilitys;
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
    public partial class LoginForm : Form
    {
        private UsuarioDAO usuarioDAO;

        public LoginForm()
        {
            InitializeComponent();

            usuarioDAO = new UsuarioDAO();

        }

        // cierra el programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // minimiza la ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;

            bool isValidNombre = isValidInput(nombre, lblErrorNombre);
            bool isValidPassword = isValidInput(password, lblErrorPassword);

            if(isValidNombre && isValidPassword)
            {

                string ePassword = Encrypt.GetSHA256(password);
                
                Usuario user = usuarioDAO.verifyUser(nombre, ePassword);

                if(user  != null)
                {
                    this.Visible = false;
                    using (MainForm mainForm = new MainForm(user.Rol))
                    {
                        mainForm.ShowDialog();
                    }

                    lblErrorLogin.Visible = false;
                } else
                {
                    lblErrorLogin.Visible = true;
                }

            }


        }

        private bool isValidInput(string text, Label label) 
        {
            label.Visible = false;

            if(String.IsNullOrEmpty(text))
            {
                label.Visible = true;

                return false;
            }

            return true;

        }

    }
}
