
namespace SistemasContables.Views
{
    partial class CatalogoDeCuentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoDeCuentasForm));
            this.tableCatalogoDeCuentas = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textCodigoCuenta = new Guna.UI.WinForms.GunaTextBox();
            this.textNombreCuenta = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregarCuenta = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textSeleccionarArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.btnSeleccionarArchivo = new Guna.UI.WinForms.GunaButton();
            this.btnCargarCatalogo = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCuenta = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableCatalogoDeCuentas)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCatalogoDeCuentas
            // 
            this.tableCatalogoDeCuentas.AllowUserToAddRows = false;
            this.tableCatalogoDeCuentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableCatalogoDeCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCatalogoDeCuentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableCatalogoDeCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCatalogoDeCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCatalogoDeCuentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tableCatalogoDeCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCatalogoDeCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableCatalogoDeCuentas.ColumnHeadersHeight = 40;
            this.tableCatalogoDeCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Nivel,
            this.Tipo});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCatalogoDeCuentas.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableCatalogoDeCuentas.EnableHeadersVisualStyles = false;
            this.tableCatalogoDeCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.Location = new System.Drawing.Point(101, 351);
            this.tableCatalogoDeCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.tableCatalogoDeCuentas.Name = "tableCatalogoDeCuentas";
            this.tableCatalogoDeCuentas.ReadOnly = true;
            this.tableCatalogoDeCuentas.RowHeadersVisible = false;
            this.tableCatalogoDeCuentas.RowHeadersWidth = 40;
            this.tableCatalogoDeCuentas.RowTemplate.Height = 40;
            this.tableCatalogoDeCuentas.RowTemplate.ReadOnly = true;
            this.tableCatalogoDeCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCatalogoDeCuentas.Size = new System.Drawing.Size(1067, 400);
            this.tableCatalogoDeCuentas.TabIndex = 36;
            this.tableCatalogoDeCuentas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableCatalogoDeCuentas.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableCatalogoDeCuentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableCatalogoDeCuentas.ThemeStyle.HeaderStyle.Height = 40;
            this.tableCatalogoDeCuentas.ThemeStyle.ReadOnly = true;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.Height = 40;
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCatalogoDeCuentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 50F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.FillWeight = 150F;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.FillWeight = 25F;
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Saldo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(432, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 41);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Catalogo de Cuentas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textCodigoCuenta);
            this.flowLayoutPanel1.Controls.Add(this.textNombreCuenta);
            this.flowLayoutPanel1.Controls.Add(this.cbTipoCuenta);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarCuenta);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 48);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // textCodigoCuenta
            // 
            this.textCodigoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.textCodigoCuenta.BaseColor = System.Drawing.Color.White;
            this.textCodigoCuenta.BorderColor = System.Drawing.Color.Silver;
            this.textCodigoCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCodigoCuenta.FocusedBaseColor = System.Drawing.Color.White;
            this.textCodigoCuenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textCodigoCuenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textCodigoCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCodigoCuenta.Location = new System.Drawing.Point(3, 3);
            this.textCodigoCuenta.Name = "textCodigoCuenta";
            this.textCodigoCuenta.PasswordChar = '\0';
            this.textCodigoCuenta.Radius = 5;
            this.textCodigoCuenta.Size = new System.Drawing.Size(250, 42);
            this.textCodigoCuenta.TabIndex = 0;
            this.textCodigoCuenta.Enter += new System.EventHandler(this.textCodigoCuenta_Enter);
            this.textCodigoCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoCuenta_KeyPress);
            // 
            // textNombreCuenta
            // 
            this.textNombreCuenta.BackColor = System.Drawing.Color.Transparent;
            this.textNombreCuenta.BaseColor = System.Drawing.Color.White;
            this.textNombreCuenta.BorderColor = System.Drawing.Color.Silver;
            this.textNombreCuenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreCuenta.FocusedBaseColor = System.Drawing.Color.White;
            this.textNombreCuenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textNombreCuenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textNombreCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNombreCuenta.Location = new System.Drawing.Point(259, 3);
            this.textNombreCuenta.Name = "textNombreCuenta";
            this.textNombreCuenta.PasswordChar = '\0';
            this.textNombreCuenta.Radius = 5;
            this.textNombreCuenta.Size = new System.Drawing.Size(350, 42);
            this.textNombreCuenta.TabIndex = 1;
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.AnimationHoverSpeed = 0.07F;
            this.btnAgregarCuenta.AnimationSpeed = 0.03F;
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCuenta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregarCuenta.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCuenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuenta.Image")));
            this.btnAgregarCuenta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarCuenta.Location = new System.Drawing.Point(856, 3);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarCuenta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarCuenta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.OnHoverImage = null;
            this.btnAgregarCuenta.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarCuenta.Radius = 5;
            this.btnAgregarCuenta.Size = new System.Drawing.Size(205, 42);
            this.btnAgregarCuenta.TabIndex = 2;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textSeleccionarArchivo);
            this.flowLayoutPanel2.Controls.Add(this.btnSeleccionarArchivo);
            this.flowLayoutPanel2.Controls.Add(this.btnCargarCatalogo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(101, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(986, 48);
            this.flowLayoutPanel2.TabIndex = 39;
            // 
            // textSeleccionarArchivo
            // 
            this.textSeleccionarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.textSeleccionarArchivo.BaseColor = System.Drawing.Color.White;
            this.textSeleccionarArchivo.BorderColor = System.Drawing.Color.Silver;
            this.textSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSeleccionarArchivo.FocusedBaseColor = System.Drawing.Color.White;
            this.textSeleccionarArchivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textSeleccionarArchivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textSeleccionarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textSeleccionarArchivo.Location = new System.Drawing.Point(3, 3);
            this.textSeleccionarArchivo.Name = "textSeleccionarArchivo";
            this.textSeleccionarArchivo.PasswordChar = '\0';
            this.textSeleccionarArchivo.Radius = 5;
            this.textSeleccionarArchivo.Size = new System.Drawing.Size(606, 42);
            this.textSeleccionarArchivo.TabIndex = 0;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionarArchivo.AnimationSpeed = 0.03F;
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarArchivo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSeleccionarArchivo.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionarArchivo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarArchivo.Image")));
            this.btnSeleccionarArchivo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(615, 3);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionarArchivo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.OnHoverImage = null;
            this.btnSeleccionarArchivo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.Radius = 5;
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(150, 42);
            this.btnSeleccionarArchivo.TabIndex = 2;
            this.btnSeleccionarArchivo.Text = "Explorar";
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // btnCargarCatalogo
            // 
            this.btnCargarCatalogo.AnimationHoverSpeed = 0.07F;
            this.btnCargarCatalogo.AnimationSpeed = 0.03F;
            this.btnCargarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCatalogo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCargarCatalogo.BorderColor = System.Drawing.Color.Black;
            this.btnCargarCatalogo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarCatalogo.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarCatalogo.Image")));
            this.btnCargarCatalogo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCargarCatalogo.Location = new System.Drawing.Point(771, 3);
            this.btnCargarCatalogo.Name = "btnCargarCatalogo";
            this.btnCargarCatalogo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCargarCatalogo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarCatalogo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.OnHoverImage = null;
            this.btnCargarCatalogo.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarCatalogo.Radius = 5;
            this.btnCargarCatalogo.Size = new System.Drawing.Size(210, 42);
            this.btnCargarCatalogo.TabIndex = 3;
            this.btnCargarCatalogo.Text = "Cargar Calatogo";
            this.btnCargarCatalogo.Click += new System.EventHandler(this.btnCargarCatalogo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(99, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cargar catalogo desde un archivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(99, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 42);
            this.label2.TabIndex = 41;
            this.label2.Text = "Agregar Cuenta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoCuenta.BaseColor = System.Drawing.Color.White;
            this.cbTipoCuenta.BorderColor = System.Drawing.Color.Silver;
            this.cbTipoCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTipoCuenta.ForeColor = System.Drawing.Color.Black;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Tipo de Saldo",
            "Activo",
            "Pasivo",
            "Patrimonio"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(615, 3);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTipoCuenta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTipoCuenta.Size = new System.Drawing.Size(235, 35);
            this.cbTipoCuenta.StartIndex = 0;
            this.cbTipoCuenta.TabIndex = 3;
            // 
            // CatalogoDeCuentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 874);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableCatalogoDeCuentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoDeCuentasForm";
            this.Text = "CatalogoDeCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.tableCatalogoDeCuentas)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView tableCatalogoDeCuentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaTextBox textCodigoCuenta;
        private Guna.UI.WinForms.GunaTextBox textNombreCuenta;
        private Guna.UI.WinForms.GunaButton btnAgregarCuenta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaTextBox textSeleccionarArchivo;
        private Guna.UI.WinForms.GunaButton btnSeleccionarArchivo;
        private Guna.UI.WinForms.GunaButton btnCargarCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbTipoCuenta;
    }
}