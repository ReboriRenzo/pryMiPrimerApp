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
            this.mrcINGREOS = new System.Windows.Forms.GroupBox();
            this.lblDEPOSITO = new System.Windows.Forms.Label();
            this.txtDEPOSITO = new System.Windows.Forms.TextBox();
            this.mrcEGRESOSFIJOS = new System.Windows.Forms.GroupBox();
            this.mrcGASTOSVARIADOS = new System.Windows.Forms.GroupBox();
            this.txtCOMIDAS = new System.Windows.Forms.TextBox();
            this.txtIMPUESTOS = new System.Windows.Forms.TextBox();
            this.txtALQUILER = new System.Windows.Forms.TextBox();
            this.lblALQUILER = new System.Windows.Forms.Label();
            this.lblIMPUESTOS = new System.Windows.Forms.Label();
            this.lblCOMIDAS = new System.Windows.Forms.Label();
            this.lblSALIDAS = new System.Windows.Forms.Label();
            this.txtSALIDAS = new System.Windows.Forms.TextBox();
            this.cmdCANCELAR = new System.Windows.Forms.Button();
            this.cmdGUARDAR = new System.Windows.Forms.Button();
            this.mrcINGREOS.SuspendLayout();
            this.mrcEGRESOSFIJOS.SuspendLayout();
            this.mrcGASTOSVARIADOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcINGREOS
            // 
            this.mrcINGREOS.Controls.Add(this.txtDEPOSITO);
            this.mrcINGREOS.Controls.Add(this.lblDEPOSITO);
            this.mrcINGREOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrcINGREOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcINGREOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcINGREOS.Location = new System.Drawing.Point(12, 12);
            this.mrcINGREOS.Name = "mrcINGREOS";
            this.mrcINGREOS.Size = new System.Drawing.Size(776, 118);
            this.mrcINGREOS.TabIndex = 0;
            this.mrcINGREOS.TabStop = false;
            this.mrcINGREOS.Text = "INGRESOS";
            this.mrcINGREOS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDEPOSITO
            // 
            this.lblDEPOSITO.AutoSize = true;
            this.lblDEPOSITO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEPOSITO.ForeColor = System.Drawing.Color.Black;
            this.lblDEPOSITO.Location = new System.Drawing.Point(48, 51);
            this.lblDEPOSITO.Name = "lblDEPOSITO";
            this.lblDEPOSITO.Size = new System.Drawing.Size(93, 18);
            this.lblDEPOSITO.TabIndex = 0;
            this.lblDEPOSITO.Text = "DEPOSITO";
            this.lblDEPOSITO.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDEPOSITO
            // 
            this.txtDEPOSITO.Location = new System.Drawing.Point(182, 51);
            this.txtDEPOSITO.Name = "txtDEPOSITO";
            this.txtDEPOSITO.Size = new System.Drawing.Size(123, 26);
            this.txtDEPOSITO.TabIndex = 1;
            // 
            // mrcEGRESOSFIJOS
            // 
            this.mrcEGRESOSFIJOS.Controls.Add(this.lblCOMIDAS);
            this.mrcEGRESOSFIJOS.Controls.Add(this.lblIMPUESTOS);
            this.mrcEGRESOSFIJOS.Controls.Add(this.lblALQUILER);
            this.mrcEGRESOSFIJOS.Controls.Add(this.txtALQUILER);
            this.mrcEGRESOSFIJOS.Controls.Add(this.txtIMPUESTOS);
            this.mrcEGRESOSFIJOS.Controls.Add(this.txtCOMIDAS);
            this.mrcEGRESOSFIJOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEGRESOSFIJOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcEGRESOSFIJOS.Location = new System.Drawing.Point(12, 136);
            this.mrcEGRESOSFIJOS.Name = "mrcEGRESOSFIJOS";
            this.mrcEGRESOSFIJOS.Size = new System.Drawing.Size(776, 174);
            this.mrcEGRESOSFIJOS.TabIndex = 1;
            this.mrcEGRESOSFIJOS.TabStop = false;
            this.mrcEGRESOSFIJOS.Text = "EGRESOS FIJOS";
            // 
            // mrcGASTOSVARIADOS
            // 
            this.mrcGASTOSVARIADOS.Controls.Add(this.txtSALIDAS);
            this.mrcGASTOSVARIADOS.Controls.Add(this.lblSALIDAS);
            this.mrcGASTOSVARIADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGASTOSVARIADOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mrcGASTOSVARIADOS.Location = new System.Drawing.Point(12, 316);
            this.mrcGASTOSVARIADOS.Name = "mrcGASTOSVARIADOS";
            this.mrcGASTOSVARIADOS.Size = new System.Drawing.Size(776, 108);
            this.mrcGASTOSVARIADOS.TabIndex = 0;
            this.mrcGASTOSVARIADOS.TabStop = false;
            this.mrcGASTOSVARIADOS.Text = "GASTOS VARIADOS";
            // 
            // txtCOMIDAS
            // 
            this.txtCOMIDAS.Location = new System.Drawing.Point(182, 118);
            this.txtCOMIDAS.Name = "txtCOMIDAS";
            this.txtCOMIDAS.Size = new System.Drawing.Size(123, 26);
            this.txtCOMIDAS.TabIndex = 0;
            // 
            // txtIMPUESTOS
            // 
            this.txtIMPUESTOS.Location = new System.Drawing.Point(182, 80);
            this.txtIMPUESTOS.Name = "txtIMPUESTOS";
            this.txtIMPUESTOS.Size = new System.Drawing.Size(123, 26);
            this.txtIMPUESTOS.TabIndex = 1;
            this.txtIMPUESTOS.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtALQUILER
            // 
            this.txtALQUILER.Location = new System.Drawing.Point(182, 40);
            this.txtALQUILER.Name = "txtALQUILER";
            this.txtALQUILER.Size = new System.Drawing.Size(123, 26);
            this.txtALQUILER.TabIndex = 2;
            // 
            // lblALQUILER
            // 
            this.lblALQUILER.AutoSize = true;
            this.lblALQUILER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALQUILER.ForeColor = System.Drawing.Color.Black;
            this.lblALQUILER.Location = new System.Drawing.Point(48, 40);
            this.lblALQUILER.Name = "lblALQUILER";
            this.lblALQUILER.Size = new System.Drawing.Size(88, 18);
            this.lblALQUILER.TabIndex = 3;
            this.lblALQUILER.Text = "ALQUILER";
            this.lblALQUILER.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIMPUESTOS
            // 
            this.lblIMPUESTOS.AutoSize = true;
            this.lblIMPUESTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMPUESTOS.ForeColor = System.Drawing.Color.Black;
            this.lblIMPUESTOS.Location = new System.Drawing.Point(48, 80);
            this.lblIMPUESTOS.Name = "lblIMPUESTOS";
            this.lblIMPUESTOS.Size = new System.Drawing.Size(105, 18);
            this.lblIMPUESTOS.TabIndex = 4;
            this.lblIMPUESTOS.Text = "IMPUESTOS";
            this.lblIMPUESTOS.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCOMIDAS
            // 
            this.lblCOMIDAS.AutoSize = true;
            this.lblCOMIDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOMIDAS.ForeColor = System.Drawing.Color.Black;
            this.lblCOMIDAS.Location = new System.Drawing.Point(48, 118);
            this.lblCOMIDAS.Name = "lblCOMIDAS";
            this.lblCOMIDAS.Size = new System.Drawing.Size(84, 18);
            this.lblCOMIDAS.TabIndex = 5;
            this.lblCOMIDAS.Text = "COMIDAS";
            // 
            // lblSALIDAS
            // 
            this.lblSALIDAS.AutoSize = true;
            this.lblSALIDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSALIDAS.ForeColor = System.Drawing.Color.Black;
            this.lblSALIDAS.Location = new System.Drawing.Point(48, 62);
            this.lblSALIDAS.Name = "lblSALIDAS";
            this.lblSALIDAS.Size = new System.Drawing.Size(75, 18);
            this.lblSALIDAS.TabIndex = 2;
            this.lblSALIDAS.Text = "SALIDAS";
            this.lblSALIDAS.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSALIDAS
            // 
            this.txtSALIDAS.Location = new System.Drawing.Point(182, 58);
            this.txtSALIDAS.Name = "txtSALIDAS";
            this.txtSALIDAS.Size = new System.Drawing.Size(123, 26);
            this.txtSALIDAS.TabIndex = 6;
            // 
            // cmdCANCELAR
            // 
            this.cmdCANCELAR.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdCANCELAR.ForeColor = System.Drawing.Color.Red;
            this.cmdCANCELAR.Location = new System.Drawing.Point(243, 440);
            this.cmdCANCELAR.Name = "cmdCANCELAR";
            this.cmdCANCELAR.Size = new System.Drawing.Size(115, 41);
            this.cmdCANCELAR.TabIndex = 2;
            this.cmdCANCELAR.Text = "CANCELAR";
            this.cmdCANCELAR.UseVisualStyleBackColor = false;
            this.cmdCANCELAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGUARDAR
            // 
            this.cmdGUARDAR.BackColor = System.Drawing.Color.Black;
            this.cmdGUARDAR.ForeColor = System.Drawing.Color.Lime;
            this.cmdGUARDAR.Location = new System.Drawing.Point(121, 440);
            this.cmdGUARDAR.Name = "cmdGUARDAR";
            this.cmdGUARDAR.Size = new System.Drawing.Size(116, 41);
            this.cmdGUARDAR.TabIndex = 3;
            this.cmdGUARDAR.Text = "GUARDAR";
            this.cmdGUARDAR.UseVisualStyleBackColor = false;
            // 
            // frmGestiónDeGastosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 493);
            this.Controls.Add(this.cmdGUARDAR);
            this.Controls.Add(this.cmdCANCELAR);
            this.Controls.Add(this.mrcGASTOSVARIADOS);
            this.Controls.Add(this.mrcEGRESOSFIJOS);
            this.Controls.Add(this.mrcINGREOS);
            this.Name = "frmGestiónDeGastosMensuales";
            this.Text = "Gestión De Gastos Mensuales";
            this.Load += new System.EventHandler(this.frmGestiónDeGastosMensuales_Load);
            this.mrcINGREOS.ResumeLayout(false);
            this.mrcINGREOS.PerformLayout();
            this.mrcEGRESOSFIJOS.ResumeLayout(false);
            this.mrcEGRESOSFIJOS.PerformLayout();
            this.mrcGASTOSVARIADOS.ResumeLayout(false);
            this.mrcGASTOSVARIADOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcINGREOS;
        private System.Windows.Forms.Label lblDEPOSITO;
        private System.Windows.Forms.TextBox txtDEPOSITO;
        private System.Windows.Forms.GroupBox mrcEGRESOSFIJOS;
        private System.Windows.Forms.TextBox txtALQUILER;
        private System.Windows.Forms.TextBox txtIMPUESTOS;
        private System.Windows.Forms.TextBox txtCOMIDAS;
        private System.Windows.Forms.GroupBox mrcGASTOSVARIADOS;
        private System.Windows.Forms.Label lblCOMIDAS;
        private System.Windows.Forms.Label lblIMPUESTOS;
        private System.Windows.Forms.Label lblALQUILER;
        private System.Windows.Forms.Label lblSALIDAS;
        private System.Windows.Forms.TextBox txtSALIDAS;
        private System.Windows.Forms.Button cmdCANCELAR;
        private System.Windows.Forms.Button cmdGUARDAR;
    }
}

