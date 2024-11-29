namespace WindowsFormsApp3
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelUsuarioText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuInicioUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioMantenimineto = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenurComprasRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuComprasVerDetalles = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioProvedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicioAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.MenuItems = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.MenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelUsuarioText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3508, 161);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evidencia3";
            // 
            // LabelUsuarioText
            // 
            this.LabelUsuarioText.AutoSize = true;
            this.LabelUsuarioText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LabelUsuarioText.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarioText.ForeColor = System.Drawing.Color.White;
            this.LabelUsuarioText.Location = new System.Drawing.Point(1308, 68);
            this.LabelUsuarioText.Name = "LabelUsuarioText";
            this.LabelUsuarioText.Size = new System.Drawing.Size(198, 55);
            this.LabelUsuarioText.TabIndex = 2;
            this.LabelUsuarioText.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1093, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 281);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2212, 710);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MenuInicioUsuarios
            // 
            this.MenuInicioUsuarios.AutoSize = false;
            this.MenuInicioUsuarios.BackColor = System.Drawing.Color.Black;
            this.MenuInicioUsuarios.ForeColor = System.Drawing.Color.White;
            this.MenuInicioUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.MenuInicioUsuarios.IconColor = System.Drawing.Color.White;
            this.MenuInicioUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioUsuarios.Name = "MenuInicioUsuarios";
            this.MenuInicioUsuarios.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioUsuarios.Text = "Usuarios";
            this.MenuInicioUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioUsuarios.Click += new System.EventHandler(this.MenuInicioUsuarios_Click);
            // 
            // MenuInicioMantenimineto
            // 
            this.MenuInicioMantenimineto.AutoSize = false;
            this.MenuInicioMantenimineto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuCategoria,
            this.SubmenuProducto});
            this.MenuInicioMantenimineto.ForeColor = System.Drawing.Color.White;
            this.MenuInicioMantenimineto.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.MenuInicioMantenimineto.IconColor = System.Drawing.Color.White;
            this.MenuInicioMantenimineto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioMantenimineto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioMantenimineto.Name = "MenuInicioMantenimineto";
            this.MenuInicioMantenimineto.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioMantenimineto.Text = "Mantenimiento";
            this.MenuInicioMantenimineto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioMantenimineto.Click += new System.EventHandler(this.MenuInicioMantenimineto_Click);
            // 
            // SubmenuCategoria
            // 
            this.SubmenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuCategoria.IconColor = System.Drawing.Color.Black;
            this.SubmenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuCategoria.Name = "SubmenuCategoria";
            this.SubmenuCategoria.Size = new System.Drawing.Size(157, 26);
            this.SubmenuCategoria.Text = "Categoria";
            this.SubmenuCategoria.Click += new System.EventHandler(this.SubmenuCategoria_Click);
            // 
            // SubmenuProducto
            // 
            this.SubmenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuProducto.IconColor = System.Drawing.Color.Black;
            this.SubmenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuProducto.Name = "SubmenuProducto";
            this.SubmenuProducto.Size = new System.Drawing.Size(157, 26);
            this.SubmenuProducto.Text = "Producto";
            this.SubmenuProducto.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // MenuInicioVentas
            // 
            this.MenuInicioVentas.AutoSize = false;
            this.MenuInicioVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrar,
            this.SubMenuVerDetalle});
            this.MenuInicioVentas.ForeColor = System.Drawing.Color.White;
            this.MenuInicioVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.MenuInicioVentas.IconColor = System.Drawing.Color.White;
            this.MenuInicioVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioVentas.Name = "MenuInicioVentas";
            this.MenuInicioVentas.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioVentas.Text = "Ventas";
            this.MenuInicioVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioVentas.Click += new System.EventHandler(this.MenuInicioVentas_Click);
            // 
            // SubMenuRegistrar
            // 
            this.SubMenuRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrar.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrar.Name = "SubMenuRegistrar";
            this.SubMenuRegistrar.Size = new System.Drawing.Size(171, 26);
            this.SubMenuRegistrar.Text = "Registrar";
            this.SubMenuRegistrar.Click += new System.EventHandler(this.SubMenuRegistrar_Click);
            // 
            // SubMenuVerDetalle
            // 
            this.SubMenuVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalle.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalle.Name = "SubMenuVerDetalle";
            this.SubMenuVerDetalle.Size = new System.Drawing.Size(171, 26);
            this.SubMenuVerDetalle.Text = "Ver Detalles";
            this.SubMenuVerDetalle.Click += new System.EventHandler(this.SubMenuVerDetalle_Click);
            // 
            // MenuInicioCompras
            // 
            this.MenuInicioCompras.AutoSize = false;
            this.MenuInicioCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenurComprasRegistrarCompra,
            this.SubMenuComprasVerDetalles});
            this.MenuInicioCompras.ForeColor = System.Drawing.Color.White;
            this.MenuInicioCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuInicioCompras.IconColor = System.Drawing.Color.White;
            this.MenuInicioCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioCompras.Name = "MenuInicioCompras";
            this.MenuInicioCompras.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioCompras.Text = "Compras";
            this.MenuInicioCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioCompras.Click += new System.EventHandler(this.MenuInicioCompras_Click);
            // 
            // SubMenurComprasRegistrarCompra
            // 
            this.SubMenurComprasRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenurComprasRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenurComprasRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenurComprasRegistrarCompra.Name = "SubMenurComprasRegistrarCompra";
            this.SubMenurComprasRegistrarCompra.Size = new System.Drawing.Size(171, 26);
            this.SubMenurComprasRegistrarCompra.Text = "Registrar";
            this.SubMenurComprasRegistrarCompra.Click += new System.EventHandler(this.SubMenurComprasRegistrarCompra_Click);
            // 
            // SubMenuComprasVerDetalles
            // 
            this.SubMenuComprasVerDetalles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuComprasVerDetalles.IconColor = System.Drawing.Color.Black;
            this.SubMenuComprasVerDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuComprasVerDetalles.Name = "SubMenuComprasVerDetalles";
            this.SubMenuComprasVerDetalles.Size = new System.Drawing.Size(171, 26);
            this.SubMenuComprasVerDetalles.Text = "Ver Detalles";
            this.SubMenuComprasVerDetalles.Click += new System.EventHandler(this.SubMenuComprasVerDetalles_Click);
            // 
            // MenuInicioClientes
            // 
            this.MenuInicioClientes.AutoSize = false;
            this.MenuInicioClientes.ForeColor = System.Drawing.Color.White;
            this.MenuInicioClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuInicioClientes.IconColor = System.Drawing.Color.White;
            this.MenuInicioClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioClientes.Name = "MenuInicioClientes";
            this.MenuInicioClientes.Size = new System.Drawing.Size(125, 101);
            this.MenuInicioClientes.Text = "Clientes";
            this.MenuInicioClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioClientes.Click += new System.EventHandler(this.MenuInicioClientes_Click);
            // 
            // MenuInicioReportes
            // 
            this.MenuInicioReportes.AutoSize = false;
            this.MenuInicioReportes.ForeColor = System.Drawing.Color.White;
            this.MenuInicioReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.MenuInicioReportes.IconColor = System.Drawing.Color.White;
            this.MenuInicioReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioReportes.Name = "MenuInicioReportes";
            this.MenuInicioReportes.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioReportes.Text = "Reportes";
            this.MenuInicioReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioReportes.Click += new System.EventHandler(this.MenuInicioReportes_Click);
            // 
            // MenuInicioProvedores
            // 
            this.MenuInicioProvedores.AutoSize = false;
            this.MenuInicioProvedores.ForeColor = System.Drawing.Color.White;
            this.MenuInicioProvedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuInicioProvedores.IconColor = System.Drawing.Color.White;
            this.MenuInicioProvedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioProvedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioProvedores.Name = "MenuInicioProvedores";
            this.MenuInicioProvedores.Size = new System.Drawing.Size(125, 101);
            this.MenuInicioProvedores.Text = "Provedores";
            this.MenuInicioProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioProvedores.Click += new System.EventHandler(this.MenuInicioProvedores_Click);
            // 
            // MenuInicioAcercaDe
            // 
            this.MenuInicioAcercaDe.AutoSize = false;
            this.MenuInicioAcercaDe.ForeColor = System.Drawing.Color.White;
            this.MenuInicioAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuInicioAcercaDe.IconColor = System.Drawing.Color.White;
            this.MenuInicioAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInicioAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInicioAcercaDe.Name = "MenuInicioAcercaDe";
            this.MenuInicioAcercaDe.Size = new System.Drawing.Size(152, 101);
            this.MenuInicioAcercaDe.Text = "Acerca de";
            this.MenuInicioAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuInicioAcercaDe.Click += new System.EventHandler(this.MenuInicioAcercaDe_Click);
            // 
            // MenuItems
            // 
            this.MenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuItems.AutoSize = false;
            this.MenuItems.BackColor = System.Drawing.Color.Black;
            this.MenuItems.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInicioUsuarios,
            this.MenuInicioMantenimineto,
            this.MenuInicioVentas,
            this.MenuInicioCompras,
            this.MenuInicioClientes,
            this.MenuInicioReportes,
            this.MenuInicioProvedores,
            this.MenuInicioAcercaDe});
            this.MenuItems.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuItems.Location = new System.Drawing.Point(0, 155);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuItems.Size = new System.Drawing.Size(2673, 124);
            this.MenuItems.TabIndex = 1;
            this.MenuItems.Text = "menuStrip1";
            this.MenuItems.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItems_ItemClicked);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuItems.ResumeLayout(false);
            this.MenuItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUsuarioText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuInicioUsuarios;
        private FontAwesome.Sharp.IconMenuItem MenuInicioMantenimineto;
        private FontAwesome.Sharp.IconMenuItem SubmenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubmenuProducto;
        private FontAwesome.Sharp.IconMenuItem MenuInicioVentas;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrar;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalle;
        private FontAwesome.Sharp.IconMenuItem MenuInicioCompras;
        private FontAwesome.Sharp.IconMenuItem SubMenurComprasRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuComprasVerDetalles;
        private FontAwesome.Sharp.IconMenuItem MenuInicioClientes;
        private FontAwesome.Sharp.IconMenuItem MenuInicioReportes;
        private FontAwesome.Sharp.IconMenuItem MenuInicioProvedores;
        private FontAwesome.Sharp.IconMenuItem MenuInicioAcercaDe;
        private System.Windows.Forms.MenuStrip MenuItems;
    }
}