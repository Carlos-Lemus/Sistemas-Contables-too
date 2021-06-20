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
        
        public LoginForm()
        {
            InitializeComponent();
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
                this.Visible = false;
                using(MainForm mainForm = new MainForm())
                {
                    mainForm.ShowDialog();
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
