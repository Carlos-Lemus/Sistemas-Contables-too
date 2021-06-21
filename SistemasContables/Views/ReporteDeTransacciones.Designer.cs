
namespace SistemasContables.Views
{
    partial class ReporteDeTransacciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableReporteDeTransacciones = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dpMes = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableReporteDeTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tableReporteDeTransacciones
            // 
            this.tableReporteDeTransacciones.AllowUserToAddRows = false;
            this.tableReporteDeTransacciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.tableReporteDeTransacciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tableReporteDeTransacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableReporteDeTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReporteDeTransacciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableReporteDeTransacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableReporteDeTransacciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReporteDeTransacciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReporteDeTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tableReporteDeTransacciones.ColumnHeadersHeight = 40;
            this.tableReporteDeTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFecha,
            this.Concepto,
            this.Total});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReporteDeTransacciones.DefaultCellStyle = dataGridViewCellStyle12;
            this.tableReporteDeTransacciones.EnableHeadersVisualStyles = false;
            this.tableReporteDeTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeTransacciones.Location = new System.Drawing.Point(66, 194);
            this.tableReporteDeTransacciones.Name = "tableReporteDeTransacciones";
            this.tableReporteDeTransacciones.ReadOnly = true;
            this.tableReporteDeTransacciones.RowHeadersVisible = false;
            this.tableReporteDeTransacciones.RowHeadersWidth = 40;
            this.tableReporteDeTransacciones.RowTemplate.Height = 40;
            this.tableReporteDeTransacciones.RowTemplate.ReadOnly = true;
            this.tableReporteDeTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableReporteDeTransacciones.Size = new System.Drawing.Size(800, 467);
            this.tableReporteDeTransacciones.TabIndex = 19;
            this.tableReporteDeTransacciones.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableReporteDeTransacciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReporteDeTransacciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableReporteDeTransacciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableReporteDeTransacciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableReporteDeTransacciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableReporteDeTransacciones.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableReporteDeTransacciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableReporteDeTransacciones.ThemeStyle.HeaderStyle.Height = 40;
            this.tableReporteDeTransacciones.ThemeStyle.ReadOnly = true;
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.Height = 40;
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeTransacciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.FillWeight = 60F;
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 65F;
            this.Total.HeaderText = "Total $";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(165, 73);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 37);
            this.lblPeriodo.TabIndex = 21;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(170, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(595, 33);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Reporte de Transacciones por Mes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpMes
            // 
            this.dpMes.BackColor = System.Drawing.Color.Transparent;
            this.dpMes.BaseColor = System.Drawing.Color.White;
            this.dpMes.BorderColor = System.Drawing.Color.Silver;
            this.dpMes.CustomFormat = "\"MM/yyyy\"";
            this.dpMes.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpMes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpMes.ForeColor = System.Drawing.Color.Black;
            this.dpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMes.Location = new System.Drawing.Point(562, 138);
            this.dpMes.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpMes.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpMes.Name = "dpMes";
            this.dpMes.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpMes.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpMes.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.dpMes.OnPressedColor = System.Drawing.Color.Black;
            this.dpMes.Radius = 5;
            this.dpMes.Size = new System.Drawing.Size(304, 35);
            this.dpMes.TabIndex = 92;
            this.dpMes.Text = "\"12/2020\"";
            this.dpMes.Value = new System.DateTime(2020, 12, 6, 18, 27, 36, 583);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(307, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 93;
            this.label1.Text = "Transacciones del mes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReporteDeTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpMes);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableReporteDeTransacciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDeTransacciones";
            this.Text = "ReporteDeTransacciones";
            ((System.ComponentModel.ISupportInitialize)(this.tableReporteDeTransacciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView tableReporteDeTransacciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaDateTimePicker dpMes;
        private System.Windows.Forms.Label label1;
    }
}