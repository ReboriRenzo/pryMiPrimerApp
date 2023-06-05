namespace pryMiPrimerApp
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtNombreDeUsuario = new System.Windows.Forms.Label();
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.lblNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.optMostrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.AutoSize = true;
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(70, 95);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(154, 21);
            this.txtNombreDeUsuario.TabIndex = 0;
            this.txtNombreDeUsuario.Text = "Nombre de Usuario";
            this.txtNombreDeUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.BackColor = System.Drawing.Color.Black;
            this.cmdIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresar.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdIngresar.Location = new System.Drawing.Point(28, 296);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(111, 38);
            this.cmdIngresar.TabIndex = 3;
            this.cmdIngresar.Text = "Ingresar";
            this.cmdIngresar.UseVisualStyleBackColor = false;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(28, 132);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(235, 27);
            this.lblNombreDeUsuario.TabIndex = 7;
            this.lblNombreDeUsuario.TextChanged += new System.EventHandler(this.lblNombreDeUsuario_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPass.Location = new System.Drawing.Point(96, 185);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(95, 21);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "Contraseña";
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblPass.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(28, 228);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(235, 27);
            this.lblPass.TabIndex = 8;
            this.lblPass.TextChanged += new System.EventHandler(this.lblContraseña_TextChanged);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIniciarSesion.Location = new System.Drawing.Point(23, 27);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(251, 47);
            this.lblIniciarSesion.TabIndex = 9;
            this.lblIniciarSesion.Text = "Iniciar Sesion";
            // 
            // optMostrar
            // 
            this.optMostrar.AutoSize = true;
            this.optMostrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optMostrar.Location = new System.Drawing.Point(177, 261);
            this.optMostrar.Name = "optMostrar";
            this.optMostrar.Size = new System.Drawing.Size(75, 21);
            this.optMostrar.TabIndex = 10;
            this.optMostrar.Text = "Mostrar";
            this.optMostrar.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(301, 344);
            this.Controls.Add(this.optMostrar);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogIn";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtNombreDeUsuario;
        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.TextBox lblNombreDeUsuario;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox lblPass;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.CheckBox optMostrar;
    }
}