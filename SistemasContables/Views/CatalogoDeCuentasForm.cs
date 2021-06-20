using Guna.UI.WinForms;
using SistemasContables.DataBase;
using SistemasContables.Models;
using SpreadsheetLight;
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
    public partial class CatalogoDeCuentasForm : Form
    {
        private CuentasController cuentaController;
        private List<Cuenta> listaCuentas;

        private List<Cuenta> listaCuentasAdd = new List<Cuenta>();

        //Variables auxiliares para establecer nivel y tipo de cuenta
        int nivelAux = 0;
        string tipoCuentaAux = "";

        public CatalogoDeCuentasForm()
        {
            InitializeComponent();

            cuentaController = new CuentasController();
            cargarTablaCatalogo();
        }

        private void textCodigoCuenta_Enter(object sender, EventArgs e)
        {
            /*
            if(textCodigoCuenta.Text == "Codigo")
            {
                textCodigoCuenta.Text = "";
                textCodigoCuenta.ForeColor = Color.LightGray;
            }
            */
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            bool isValidCodigo = isValidInput(textCodigoCuenta.Text.ToString(), "Codigo de Cuenta");
            bool isValidCuenta = isValidInput(textNombreCuenta.Text.ToString(), "Nombre de Cuenta");
            bool isValidTipo = isValidInput(cbTipoCuenta.SelectedIndex.ToString(), "Tipo de Cuenta");

            if (isValidCodigo && isValidCuenta && isValidTipo)
            {
                //int codigoCuenta = Convert.ToInt32(textCodigoCuenta.Text.ToString());
                string codigoCuenta = textCodigoCuenta.Text;
                string nombreCuenta = textNombreCuenta.Text;

                int nivel = establecerNivel(Convert.ToInt32(codigoCuenta));
                string tipo = cbTipoCuenta.SelectedItem.ToString();

                bool add = cuentaController.agregarCuenta(new Cuenta(0, nombreCuenta, codigoCuenta, nivel, tipo));
                if (add)
                {
                    MessageBox.Show(null, "Se agrego la cuenta con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textCodigoCuenta.Text = "";
                    textNombreCuenta.Text = "";
                }
                else
                {
                    MessageBox.Show(null, "No se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            cargarTablaCatalogo();
        }

        private void btnCargarCatalogo_Click(object sender, EventArgs e)
        {
            string direccion = textSeleccionarArchivo.Text;

            bool isValidDireccion = isValidInput(direccion, "Archivo que cargar");

            if (isValidDireccion)
            {
                cargarExel();
            }
        }

        private void cargarTablaCatalogo()
        {
            if(tableCatalogoDeCuentas.RowCount > 0)
            {
                tableCatalogoDeCuentas.Rows.Clear();
                listaCuentas.Clear();
            }

            listaCuentas = cuentaController.getList();
            //listaCuentas = cuentaController.listaNivelTipo(3, "PATRIMONIO");
            //listaCuentas = cuentaController.listaNivel(2);

            foreach (Cuenta cuenta in listaCuentas)
            {
                tableCatalogoDeCuentas.Rows.Add(cuenta.Codigo, cuenta.Nombre, cuenta.Nivel, cuenta.TipoSaldo);
            }
        }

        private void cargarExel()
        {
            try
            {
                SLDocument sl = new SLDocument(textSeleccionarArchivo.Text.ToString());
                string[] info = new string[5];

                int valor = 1;
                int codigoAux;
                string tipoAux = "";

                if(listaCuentasAdd != null)
                {
                    listaCuentasAdd.Clear();
                }

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(valor, 1)))
                {
                    codigoAux = Int32.Parse(sl.GetCellValueAsString(valor, 1));
                    tipoAux = establecerTipo(codigoAux, sl.GetCellValueAsString(valor, 2));

                    listaCuentasAdd.Add(new Cuenta(0, sl.GetCellValueAsString(valor, 2), sl.GetCellValueAsString(valor, 1), establecerNivel(codigoAux), tipoAux));

                    valor++;
                }

                bool add = cuentaController.agregarListaDeCuentas(listaCuentasAdd);
                if (add)
                {
                    MessageBox.Show(null, "Se cargo el catalogo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textSeleccionarArchivo.Text = "";
                }

            }
            catch(Exception exception)
            {
                MessageBox.Show(null, exception.Message, "Error al cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarTablaCatalogo();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCatalogo;

            openFileDialogCatalogo = new OpenFileDialog()
            {
                FileName = "Seleccione el archivo de catalogo",
                Filter = "Exel Files (*.xlsx)|*.xlsx",
                Title = "Abrir archivo de catalogo de cuentas"
            };

            if (openFileDialogCatalogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //var sr = new StreamReader(openFileDialog1.FileName);
                    string sr = openFileDialogCatalogo.FileName;
                    textSeleccionarArchivo.Text = sr;
                }
                catch (System.Security.SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private bool isValidInput(String txtInput, string campo)
        {
            if (String.IsNullOrEmpty(txtInput) || txtInput == "0")
            {
                MessageBox.Show(null,"Ingrese un " + campo, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            return true;
        }

        private int establecerNivel(int codigo)
        {
            if (codigo < 10)
            {
                return 1;
            }
            else if (codigo < 100)
            {
                return 2;
            }
            else if (codigo < 1000)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        private string establecerTipo(int codigo, string cuenta)
        {

            if (codigo < 10 && codigo > nivelAux)
            {
                nivelAux = codigo;
                tipoCuentaAux = cuenta;
            }

            return tipoCuentaAux;
        }

        private void textCodigoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
