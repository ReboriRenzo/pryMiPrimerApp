namespace pryMiPrimerApp
{
    partial class frmGestiónDeGastosMensuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiónDeGastosMensuales));
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcEgresosFijos = new System.Windows.Forms.GroupBox();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.mrcGastosVariados = new System.Windows.Forms.GroupBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.mrcIngresos.SuspendLayout();
            this.mrcEgresosFijos.SuspendLayout();
            this.mrcGastosVariados.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcIngresos.Location = new System.Drawing.Point(12, 12);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(250, 84);
            this.mrcIngresos.TabIndex = 0;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            this.mrcIngresos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(116, 39);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(123, 26);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtDeposito_TextChanged);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.ForeColor = System.Drawing.Color.Black;
            this.lblDeposito.Location = new System.Drawing.Point(13, 43);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(85, 18);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Depositos";
            this.lblDeposito.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcEgresosFijos
            // 
            this.mrcEgresosFijos.Controls.Add(this.lblComidas);
            this.mrcEgresosFijos.Controls.Add(this.lblImpuestos);
            this.mrcEgresosFijos.Controls.Add(this.lblAlquiler);
            this.mrcEgresosFijos.Controls.Add(this.txtAlquiler);
            this.mrcEgresosFijos.Controls.Add(this.txtImpuestos);
            this.mrcEgresosFijos.Controls.Add(this.txtComidas);
            this.mrcEgresosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEgresosFijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcEgresosFijos.Location = new System.Drawing.Point(12, 105);
            this.mrcEgresosFijos.Name = "mrcEgresosFijos";
            this.mrcEgresosFijos.Size = new System.Drawing.Size(239, 174);
            this.mrcEgresosFijos.TabIndex = 1;
            this.mrcEgresosFijos.TabStop = false;
            this.mrcEgresosFijos.Text = "Egresos Fijos";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComidas.ForeColor = System.Drawing.Color.Black;
            this.lblComidas.Location = new System.Drawing.Point(15, 119);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(75, 18);
            this.lblComidas.TabIndex = 5;
            this.lblComidas.Text = "Comidas";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.Color.Black;
            this.lblImpuestos.Location = new System.Drawing.Point(15, 81);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(86, 18);
            this.lblImpuestos.TabIndex = 4;
            this.lblImpuestos.Text = "Impuestos";
            this.lblImpuestos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.ForeColor = System.Drawing.Color.Black;
            this.lblAlquiler.Location = new System.Drawing.Point(15, 41);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(63, 18);
            this.lblAlquiler.TabIndex = 3;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(84, 37);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(123, 26);
            this.txtAlquiler.TabIndex = 2;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(107, 77);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(123, 26);
            this.txtImpuestos.TabIndex = 1;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(96, 119);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Size = new System.Drawing.Size(123, 26);
            this.txtComidas.TabIndex = 0;
            this.txtComidas.TextChanged += new System.EventHandler(this.txtComidas_TextChanged);
            // 
            // mrcGastosVariados
            // 
            this.mrcGastosVariados.Controls.Add(this.txtSalidas);
            this.mrcGastosVariados.Controls.Add(this.lblSalidas);
            this.mrcGastosVariados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVariados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcGastosVariados.Location = new System.Drawing.Point(12, 285);
            this.mrcGastosVariados.Name = "mrcGastosVariados";
            this.mrcGastosVariados.Size = new System.Drawing.Size(219, 67);
            this.mrcGastosVariados.TabIndex = 0;
            this.mrcGastosVariados.TabStop = false;
            this.mrcGastosVariados.Text = "Gastos Variados";
            // 
            // txtSalidas
            // 
            this.txtSalidas.Location = new System.Drawing.Point(84, 29);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(123, 26);
            this.txtSalidas.TabIndex = 6;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidas.ForeColor = System.Drawing.Color.Black;
            this.lblSalidas.Location = new System.Drawing.Point(15, 29);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(63, 18);
            this.lblSalidas.TabIndex = 2;
            this.lblSalidas.Text = "Salidas";
            this.lblSalidas.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancelar.Location = new System.Drawing.Point(136, 358);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(115, 41);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 358);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(116, 41);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "Calcular";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(12, 411);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(0, 20);
            this.lblCalculo.TabIndex = 4;
            this.lblCalculo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmGestiónDeGastosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 453);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVariados);
            this.Controls.Add(this.mrcEgresosFijos);
            this.Controls.Add(this.mrcIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestiónDeGastosMensuales";
            this.Text = "Gestión De Gastos Mensuales";
            this.Load += new System.EventHandler(this.frmGestiónDeGastosMensuales_Load);
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcEgresosFijos.ResumeLayout(false);
            this.mrcEgresosFijos.PerformLayout();
            this.mrcGastosVariados.ResumeLayout(false);
            this.mrcGastosVariados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcEgresosFijos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.GroupBox mrcGastosVariados;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblCalculo;
    }
}

