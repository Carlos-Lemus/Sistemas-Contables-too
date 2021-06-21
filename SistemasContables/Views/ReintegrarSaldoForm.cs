using Guna.UI.WinForms;
using SistemasContables.controller;
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
    public partial class ReintegrarSaldoForm : Form
    {
        private bool isBanco;
        private LibroDiariosController libroDiariosController;
        private int idLibroDiario;

        public ReintegrarSaldoForm(bool isBanco, int idLibroDiario, LibroDiariosController libroDiariosController, double totalActual)
        {
            InitializeComponent();

            this.isBanco = isBanco;
            this.idLibroDiario = idLibroDiario;
            this.libroDiariosController = libroDiariosController;

            txtMonto.Text = totalActual.ToString();

            if (isBanco)
            {
                lblTitulo.Text = "Reintegrar Banco";
            }
        }

        
        private void btnCambiarSaldo_Click(object sender, EventArgs e)
        {
            string montoText = txtMonto.Text;

            if(string.IsNullOrEmpty(montoText))
            {
                lblError.Visible = true;
                return;
            }            


            if(isBanco)
            {
                libroDiariosController.updateBanco(idLibroDiario, Convert.ToDouble(montoText));

            } else
            {

                libroDiariosController.updateCajaChica(idLibroDiario, Convert.ToDouble(montoText));
            }

            this.Close();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite del 0 al 9, backspace, y punto decimal
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            // comprueba que solo sea un decimal
            if (e.KeyChar == 46)
            {
                if ((sender as GunaTextBox).Text.IndexOf(e.KeyChar) != -1 || (sender as GunaTextBox).Text.Length == 0)
                {
                    e.Handled = true;
                }

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

    }
}
