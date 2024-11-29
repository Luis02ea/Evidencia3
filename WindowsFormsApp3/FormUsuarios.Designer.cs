namespace CapaPresentacion
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPuntoDeVentasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.CbBuscarPor = new System.Windows.Forms.ComboBox();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnBuscarUsua = new FontAwesome.Sharp.IconButton();
            this.BuscarPor = new System.Windows.Forms.Label();
            this.BtnLimpiarUsua = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPuntoDeVentasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdUsuario,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.Estado,
            this.IdRol,
            this.oRol,
            this.EstadoValor});
            this.DgvData.GridColor = System.Drawing.Color.Black;
            this.DgvData.Location = new System.Drawing.Point(31, 211);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 51;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.Size = new System.Drawing.Size(1392, 520);
            this.DgvData.TabIndex = 19;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.IdUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 150;
            // 
            // Documento
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Documento.HeaderText = "No.Documento";
            this.Documento.MinimumWidth = 10;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 175;
            // 
            // NombreCompleto
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.NombreCompleto.DefaultCellStyle = dataGridViewCellStyle4;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 10;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 230;
            // 
            // Correo
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Correo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 10;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 175;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            this.Clave.Width = 125;
            // 
            // Estado
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 10;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 175;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // oRol
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.oRol.DefaultCellStyle = dataGridViewCellStyle7;
            this.oRol.HeaderText = "Rol";
            this.oRol.MinimumWidth = 10;
            this.oRol.Name = "oRol";
            this.oRol.ReadOnly = true;
            this.oRol.Width = 175;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-25, -147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // CbBuscarPor
            // 
            this.CbBuscarPor.BackColor = System.Drawing.Color.DimGray;
            this.CbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBuscarPor.FormattingEnabled = true;
            this.CbBuscarPor.Location = new System.Drawing.Point(852, 109);
            this.CbBuscarPor.Name = "CbBuscarPor";
            this.CbBuscarPor.Size = new System.Drawing.Size(211, 30);
            this.CbBuscarPor.TabIndex = 24;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(1082, 107);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(190, 30);
            this.TxtBusqueda.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 46);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalles Del Usuario";
            // 
            // BtnBuscarUsua
            // 
            this.BtnBuscarUsua.BackColor = System.Drawing.Color.Black;
            this.BtnBuscarUsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscarUsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarUsua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscarUsua.FlatAppearance.BorderSize = 3;
            this.BtnBuscarUsua.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarUsua.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarUsua.IconColor = System.Drawing.Color.White;
            this.BtnBuscarUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarUsua.IconSize = 20;
            this.BtnBuscarUsua.Location = new System.Drawing.Point(1278, 98);
            this.BtnBuscarUsua.Name = "BtnBuscarUsua";
            this.BtnBuscarUsua.Size = new System.Drawing.Size(70, 39);
            this.BtnBuscarUsua.TabIndex = 25;
            this.BtnBuscarUsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarUsua.UseVisualStyleBackColor = false;
            // 
            // BuscarPor
            // 
            this.BuscarPor.AutoSize = true;
            this.BuscarPor.BackColor = System.Drawing.Color.Black;
            this.BuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPor.ForeColor = System.Drawing.Color.White;
            this.BuscarPor.Location = new System.Drawing.Point(700, 110);
            this.BuscarPor.Name = "BuscarPor";
            this.BuscarPor.Size = new System.Drawing.Size(146, 29);
            this.BuscarPor.TabIndex = 22;
            this.BuscarPor.Text = "Buscar por:";
            // 
            // BtnLimpiarUsua
            // 
            this.BtnLimpiarUsua.BackColor = System.Drawing.Color.Black;
            this.BtnLimpiarUsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpiarUsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarUsua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLimpiarUsua.FlatAppearance.BorderSize = 5;
            this.BtnLimpiarUsua.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarUsua.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarUsua.IconColor = System.Drawing.Color.White;
            this.BtnLimpiarUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarUsua.IconSize = 20;
            this.BtnLimpiarUsua.Location = new System.Drawing.Point(1354, 98);
            this.BtnLimpiarUsua.Name = "BtnLimpiarUsua";
            this.BtnLimpiarUsua.Size = new System.Drawing.Size(67, 39);
            this.BtnLimpiarUsua.TabIndex = 26;
            this.BtnLimpiarUsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarUsua.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(560, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 70);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lista de Usuarios:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BtnLimpiarUsua);
            this.panel1.Controls.Add(this.BuscarPor);
            this.panel1.Controls.Add(this.BtnBuscarUsua);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtBusqueda);
            this.panel1.Controls.Add(this.CbBuscarPor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 170);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1446, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DgvData);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPuntoDeVentasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource dbPuntoDeVentasDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private System.Windows.Forms.BindingSource usuariosBindingSource3;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.ComboBox CbBuscarPor;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton BtnBuscarUsua;
        private System.Windows.Forms.Label BuscarPor;
        private FontAwesome.Sharp.IconButton BtnLimpiarUsua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}