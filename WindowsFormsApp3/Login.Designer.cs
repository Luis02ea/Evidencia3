namespace WindowsFormsApp3
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogginSalirBtn = new FontAwesome.Sharp.IconButton();
            this.LoginInicioButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtLoginClave = new System.Windows.Forms.TextBox();
            this.TxtLoginUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.LogginSalirBtn);
            this.panel3.Controls.Add(this.LoginInicioButton);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.TxtLoginClave);
            this.panel3.Controls.Add(this.TxtLoginUsuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(580, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 606);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // LogginSalirBtn
            // 
            this.LogginSalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogginSalirBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LogginSalirBtn.FlatAppearance.BorderSize = 2;
            this.LogginSalirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogginSalirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogginSalirBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LogginSalirBtn.IconColor = System.Drawing.Color.Black;
            this.LogginSalirBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogginSalirBtn.Location = new System.Drawing.Point(282, 443);
            this.LogginSalirBtn.Name = "LogginSalirBtn";
            this.LogginSalirBtn.Size = new System.Drawing.Size(98, 44);
            this.LogginSalirBtn.TabIndex = 8;
            this.LogginSalirBtn.Text = "Salir";
            this.LogginSalirBtn.UseVisualStyleBackColor = true;
            // 
            // LoginInicioButton
            // 
            this.LoginInicioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginInicioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginInicioButton.FlatAppearance.BorderSize = 2;
            this.LoginInicioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginInicioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInicioButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LoginInicioButton.IconColor = System.Drawing.Color.Black;
            this.LoginInicioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginInicioButton.Location = new System.Drawing.Point(70, 443);
            this.LoginInicioButton.Name = "LoginInicioButton";
            this.LoginInicioButton.Size = new System.Drawing.Size(98, 44);
            this.LoginInicioButton.TabIndex = 7;
            this.LoginInicioButton.Text = "Inicio";
            this.LoginInicioButton.UseVisualStyleBackColor = true;
            this.LoginInicioButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 78);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // TxtLoginClave
            // 
            this.TxtLoginClave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginClave.Location = new System.Drawing.Point(40, 369);
            this.TxtLoginClave.Name = "TxtLoginClave";
            this.TxtLoginClave.PasswordChar = '*';
            this.TxtLoginClave.Size = new System.Drawing.Size(426, 34);
            this.TxtLoginClave.TabIndex = 5;
            // 
            // TxtLoginUsuario
            // 
            this.TxtLoginUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginUsuario.Location = new System.Drawing.Point(39, 235);
            this.TxtLoginUsuario.Name = "TxtLoginUsuario";
            this.TxtLoginUsuario.Size = new System.Drawing.Size(426, 34);
            this.TxtLoginUsuario.TabIndex = 4;
            this.TxtLoginUsuario.TextChanged += new System.EventHandler(this.TxtLoginUsuario_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 670);
            this.panel1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1085, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton LoginInicioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtLoginClave;
        private System.Windows.Forms.TextBox TxtLoginUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton LogginSalirBtn;
    }
}

