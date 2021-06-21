using Guna.UI.WinForms;
using SistemasContables.controller;
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
    public partial class AgregarLibroDiarioForm : Form
    {
        private LibroDiariosController libroDiarioController;
        private string periodo;
        private string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre","Octubre", "Noviembre", "Diciembre"};

        public AgregarLibroDiarioForm(int idLibroDiario)
        {
            InitializeComponent();
            libroDiarioController = new LibroDiariosController();

            idLibroDiario++;
            lblNumLibro.Text += idLibroDiario;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

            llenarPeriodo();

            string cajaChica = txtCajaChica.Text;
            string banco = txtBanco.Text;

            bool isValidCajaChica = isValidInput(cajaChica, lblErrorCajaChica, "Este campo es obligatorio");
            bool isValidBanco = isValidInput(banco, lblErrorBanco, "Este campo es obligatorio");

            if(!string.IsNullOrEmpty(periodo) && isValidCajaChica && isValidBanco)
            {
                if(Convert.ToDouble(cajaChica) < 1 ||Convert.ToDouble(cajaChica) > 1000)
                {
                    lblErrorCajaChica.Text = "Debe de ser < 1000 y > 1";
                    lblErrorCajaChica.Visible = true;

                    return;
                }

                if (Convert.ToDouble(banco) <= 1000)
                {
                    lblErrorBanco.Text = "Debe mayor de 1000";
                    lblErrorBanco.Visible = true;

                    return;
                }

                LibroDiario libroDiario = new LibroDiario();

                libroDiario.Periodo = periodo;
                libroDiario.CajaChica = Convert.ToDouble(cajaChica);
                libroDiario.Banco = Convert.ToDouble(banco);

                bool resultado = libroDiarioController.insert(libroDiario);

                if (resultado)
                {
                    MessageBox.Show("Se ingreso el libro diario con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logro ingresar el libro diario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            } 
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCajaChica_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void llenarPeriodo()
        {

            int dayDesde = dpDesde.Value.Day;
            int monthDesde = dpDesde.Value.Month;
            int yearDesde = dpDesde.Value.Year;

            int dayHasta = dpHasta.Value.Day;
            int monthHasta = dpHasta.Value.Month;
            int yearHasta = dpHasta.Value.Year;

            if(yearDesde < yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else if(monthDesde < monthHasta && yearDesde == yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else if(dayDesde < dayHasta && monthDesde == monthHasta && yearDesde == yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else
            {
                periodo = null;
                MessageBox.Show("La fecha desde tiene que ser menor a la fecha hasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private bool isValidInput(string text, Label label, string mensaje)
        {
            label.Visible = false;

            if (String.IsNullOrEmpty(text))
            {
                label.Visible = true;
                label.Text = mensaje;

                return false;
            }

            return true;

        }

    }
}
