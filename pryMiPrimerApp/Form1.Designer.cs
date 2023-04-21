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
            this.lblDEPOSITO = new System.Windows.Forms.Label();
            this.mrcEgresosFijos = new System.Windows.Forms.GroupBox();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtIMPUESTOS = new System.Windows.Forms.TextBox();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.mrcGastosVariados = new System.Windows.Forms.GroupBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.mrcIngresos.SuspendLayout();
            this.mrcEgresosFijos.SuspendLayout();
            this.mrcGastosVariados.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lblDEPOSITO);
            this.mrcIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcIngresos.Location = new System.Drawing.Point(12, 12);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(325, 84);
            this.mrcIngresos.TabIndex = 0;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            this.mrcIngresos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(174, 36);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(123, 26);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDEPOSITO
            // 
            this.lblDEPOSITO.AutoSize = true;
            this.lblDEPOSITO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEPOSITO.ForeColor = System.Drawing.Color.Black;
            this.lblDEPOSITO.Location = new System.Drawing.Point(38, 44);
            this.lblDEPOSITO.Name = "lblDEPOSITO";
            this.lblDEPOSITO.Size = new System.Drawing.Size(85, 18);
            this.lblDEPOSITO.TabIndex = 0;
            this.lblDEPOSITO.Text = "Depositos";
            this.lblDEPOSITO.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcEgresosFijos
            // 
            this.mrcEgresosFijos.Controls.Add(this.lblComidas);
            this.mrcEgresosFijos.Controls.Add(this.lblImpuestos);
            this.mrcEgresosFijos.Controls.Add(this.lblAlquiler);
            this.mrcEgresosFijos.Controls.Add(this.txtAlquiler);
            this.mrcEgresosFijos.Controls.Add(this.txtIMPUESTOS);
            this.mrcEgresosFijos.Controls.Add(this.txtComidas);
            this.mrcEgresosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEgresosFijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcEgresosFijos.Location = new System.Drawing.Point(12, 105);
            this.mrcEgresosFijos.Name = "mrcEgresosFijos";
            this.mrcEgresosFijos.Size = new System.Drawing.Size(325, 174);
            this.mrcEgresosFijos.TabIndex = 1;
            this.mrcEgresosFijos.TabStop = false;
            this.mrcEgresosFijos.Text = "Egresos Fijos";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComidas.ForeColor = System.Drawing.Color.Black;
            this.lblComidas.Location = new System.Drawing.Point(48, 118);
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
            this.lblImpuestos.Location = new System.Drawing.Point(48, 80);
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
            this.lblAlquiler.Location = new System.Drawing.Point(48, 40);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(63, 18);
            this.lblAlquiler.TabIndex = 3;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(182, 32);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(123, 26);
            this.txtAlquiler.TabIndex = 2;
            // 
            // txtIMPUESTOS
            // 
            this.txtIMPUESTOS.Location = new System.Drawing.Point(182, 80);
            this.txtIMPUESTOS.Name = "txtIMPUESTOS";
            this.txtIMPUESTOS.Size = new System.Drawing.Size(123, 26);
            this.txtIMPUESTOS.TabIndex = 1;
            this.txtIMPUESTOS.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(182, 118);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Size = new System.Drawing.Size(123, 26);
            this.txtComidas.TabIndex = 0;
            // 
            // mrcGastosVariados
            // 
            this.mrcGastosVariados.Controls.Add(this.txtSalidas);
            this.mrcGastosVariados.Controls.Add(this.lblSalidas);
            this.mrcGastosVariados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVariados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcGastosVariados.Location = new System.Drawing.Point(12, 285);
            this.mrcGastosVariados.Name = "mrcGastosVariados";
            this.mrcGastosVariados.Size = new System.Drawing.Size(325, 67);
            this.mrcGastosVariados.TabIndex = 0;
            this.mrcGastosVariados.TabStop = false;
            this.mrcGastosVariados.Text = "Gastos Variados";
            // 
            // txtSalidas
            // 
            this.txtSalidas.Location = new System.Drawing.Point(182, 25);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(123, 26);
            this.txtSalidas.TabIndex = 6;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidas.ForeColor = System.Drawing.Color.Black;
            this.lblSalidas.Location = new System.Drawing.Point(48, 25);
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
            this.cmdCancelar.Location = new System.Drawing.Point(194, 358);
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
            this.cmdGuardar.Location = new System.Drawing.Point(30, 358);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(116, 41);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // frmGestiónDeGastosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 416);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Label lblDEPOSITO;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcEgresosFijos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtIMPUESTOS;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.GroupBox mrcGastosVariados;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
    }
}

