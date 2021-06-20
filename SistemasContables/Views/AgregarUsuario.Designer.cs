
namespace SistemasContables.Views
{
    partial class AgregarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUSer = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboTipo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnGuardarUser = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarUser = new Guna.UI.WinForms.GunaButton();
            this.txtContraUser = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(685, 49);
            this.panelTop.TabIndex = 116;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 49);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(549, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(68, 49);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(617, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nombre de usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreUSer
            // 
            this.txtNombreUSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUSer.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreUSer.BaseColor = System.Drawing.Color.White;
            this.txtNombreUSer.BorderColor = System.Drawing.Color.Silver;
            this.txtNombreUSer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUSer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreUSer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtNombreUSer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreUSer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreUSer.Location = new System.Drawing.Point(128, 229);
            this.txtNombreUSer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUSer.Name = "txtNombreUSer";
            this.txtNombreUSer.PasswordChar = '\0';
            this.txtNombreUSer.Radius = 5;
            this.txtNombreUSer.Size = new System.Drawing.Size(425, 46);
            this.txtNombreUSer.TabIndex = 127;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(123, 418);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 28);
            this.label14.TabIndex = 119;
            this.label14.Text = "Tipo de usuario";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.Transparent;
            this.comboTipo.BaseColor = System.Drawing.Color.White;
            this.comboTipo.BorderColor = System.Drawing.Color.Silver;
            this.comboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FocusedColor = System.Drawing.Color.Empty;
            this.comboTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTipo.ForeColor = System.Drawing.Color.Black;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Administrador",
            "Contador"});
            this.comboTipo.Location = new System.Drawing.Point(128, 464);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboTipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboTipo.Size = new System.Drawing.Size(425, 31);
            this.comboTipo.TabIndex = 117;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.AnimationHoverSpeed = 0.07F;
            this.btnGuardarUser.AnimationSpeed = 0.03F;
            this.btnGuardarUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardarUser.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarUser.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUser.Image = null;
            this.btnGuardarUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardarUser.Location = new System.Drawing.Point(128, 530);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardarUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarUser.OnHoverImage = null;
            this.btnGuardarUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarUser.Size = new System.Drawing.Size(425, 42);
            this.btnGuardarUser.TabIndex = 128;
            this.btnGuardarUser.Text = "Agregar";
            this.btnGuardarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(79, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 41);
            this.label2.TabIndex = 129;
            this.label2.Text = "Agregar nuevo usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.AnimationHoverSpeed = 0.07F;
            this.btnEditarUser.AnimationSpeed = 0.03F;
            this.btnEditarUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarUser.BorderColor = System.Drawing.Color.Black;
            this.btnEditarUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditarUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditarUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarUser.ForeColor = System.Drawing.Color.White;
            this.btnEditarUser.Image = null;
            this.btnEditarUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditarUser.Location = new System.Drawing.Point(128, 530);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditarUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditarUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditarUser.OnHoverImage = null;
            this.btnEditarUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditarUser.Size = new System.Drawing.Size(425, 42);
            this.btnEditarUser.TabIndex = 130;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditarUser.Click += new System.EventHandler(this.btnEditarUser_Click);
            // 
            // txtContraUser
            // 
            this.txtContraUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraUser.BackColor = System.Drawing.Color.Transparent;
            this.txtContraUser.BaseColor = System.Drawing.Color.White;
            this.txtContraUser.BorderColor = System.Drawing.Color.Silver;
            this.txtContraUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContraUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtContraUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContraUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContraUser.Location = new System.Drawing.Point(128, 343);
            this.txtContraUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraUser.Name = "txtContraUser";
            this.txtContraUser.PasswordChar = '\0';
            this.txtContraUser.Radius = 5;
            this.txtContraUser.Size = new System.Drawing.Size(425, 46);
            this.txtContraUser.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(123, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 131;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 652);
            this.Controls.Add(this.txtContraUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarUser);
            this.Controls.Add(this.txtNombreUSer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtNombreUSer;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaComboBox comboTipo;
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton btnGuardarUser;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnEditarUser;
        private Guna.UI.WinForms.GunaTextBox txtContraUser;
        private System.Windows.Forms.Label label3;
    }
}