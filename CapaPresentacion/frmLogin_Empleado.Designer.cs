namespace CapaPresentacion
{
    partial class frmLogin_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin_Empleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Registrarse = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.LinkLabel();
            this.PanelRestaurarCuenta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RecupCon = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCorreos = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PanelRestaurarCuenta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(51, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 254);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(341, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(444, 255);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCESO AL SISTEMA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(119, 33);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 17);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "lblHora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(185, 138);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(201, 22);
            this.txtContraseña.TabIndex = 13;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(185, 87);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 22);
            this.txtUsuario.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "USUARIO";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(95, 209);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(239, 209);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 30);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(0, 0);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(100, 23);
            this.Registrarse.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 53);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.Location = new System.Drawing.Point(0, 361);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 53);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "SISTEMA DE VENTAS";
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.LinkColor = System.Drawing.Color.White;
            this.Registro.Location = new System.Drawing.Point(641, 16);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(127, 20);
            this.Registro.TabIndex = 14;
            this.Registro.TabStop = true;
            this.Registro.Text = "REGISTRARSE";
            this.Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registro_LinkClicked);
            // 
            // PanelRestaurarCuenta
            // 
            this.PanelRestaurarCuenta.Controls.Add(this.btnCerrar);
            this.PanelRestaurarCuenta.Controls.Add(this.label6);
            this.PanelRestaurarCuenta.Controls.Add(this.btnEnviar);
            this.PanelRestaurarCuenta.Controls.Add(this.cbCorreos);
            this.PanelRestaurarCuenta.Controls.Add(this.label5);
            this.PanelRestaurarCuenta.Controls.Add(this.label4);
            this.PanelRestaurarCuenta.Location = new System.Drawing.Point(212, 71);
            this.PanelRestaurarCuenta.Name = "PanelRestaurarCuenta";
            this.PanelRestaurarCuenta.Size = new System.Drawing.Size(493, 366);
            this.PanelRestaurarCuenta.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "RECUPERAR CONTRASEÑA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.RecupCon);
            this.panel2.Controls.Add(this.Registro);
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 53);
            this.panel2.TabIndex = 15;
            // 
            // RecupCon
            // 
            this.RecupCon.AutoSize = true;
            this.RecupCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecupCon.LinkArea = new System.Windows.Forms.LinkArea(0, 25);
            this.RecupCon.LinkColor = System.Drawing.Color.White;
            this.RecupCon.Location = new System.Drawing.Point(336, 11);
            this.RecupCon.Name = "RecupCon";
            this.RecupCon.Size = new System.Drawing.Size(235, 25);
            this.RecupCon.TabIndex = 15;
            this.RecupCon.TabStop = true;
            this.RecupCon.Text = "¿olvidaste tu contraseña?";
            this.RecupCon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RecupCon_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Correo Electronico";
            // 
            // cbCorreos
            // 
            this.cbCorreos.FormattingEnabled = true;
            this.cbCorreos.Location = new System.Drawing.Point(182, 126);
            this.cbCorreos.Name = "cbCorreos";
            this.cbCorreos.Size = new System.Drawing.Size(288, 24);
            this.cbCorreos.TabIndex = 2;
            this.cbCorreos.SelectedIndexChanged += new System.EventHandler(this.cbCorreos_SelectedIndexChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Cyan;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEnviar.FlatAppearance.BorderSize = 5;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(184, 213);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(224, 35);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(182, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "EL QUE REGISTRASTE A TU CUENTA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(59, 283);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmLogin_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(796, 414);
            this.Controls.Add(this.PanelRestaurarCuenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin_Empleado";
            this.Load += new System.EventHandler(this.frmLogin_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PanelRestaurarCuenta.ResumeLayout(false);
            this.PanelRestaurarCuenta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel Registrarse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Registro;
        private System.Windows.Forms.Panel PanelRestaurarCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel RecupCon;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbCorreos;
        private System.Windows.Forms.Label label5;
    }
}