namespace pryMiPrimerApp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdFinanzas = new System.Windows.Forms.Button();
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFinanzas
            // 
            this.cmdFinanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinanzas.Location = new System.Drawing.Point(12, 12);
            this.cmdFinanzas.Name = "cmdFinanzas";
            this.cmdFinanzas.Size = new System.Drawing.Size(127, 62);
            this.cmdFinanzas.TabIndex = 0;
            this.cmdFinanzas.Text = "Finanzas";
            this.cmdFinanzas.UseVisualStyleBackColor = false;
            this.cmdFinanzas.Click += new System.EventHandler(this.cmdFinanzas_Click);
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.BackColor = System.Drawing.Color.Cyan;
            this.cmdAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlacena.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmdAlacena.Location = new System.Drawing.Point(12, 80);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(127, 56);
            this.cmdAlacena.TabIndex = 1;
            this.cmdAlacena.Text = "Alacena";
            this.cmdAlacena.UseVisualStyleBackColor = false;
            this.cmdAlacena.Click += new System.EventHandler(this.cmdAlacena_Click);
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.BackColor = System.Drawing.Color.Lime;
            this.cmdLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogIn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmdLogIn.Location = new System.Drawing.Point(12, 142);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(127, 56);
            this.cmdLogIn.TabIndex = 2;
            this.cmdLogIn.Text = "LogIn";
            this.cmdLogIn.UseVisualStyleBackColor = false;
            this.cmdLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 216);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.cmdAlacena);
            this.Controls.Add(this.cmdFinanzas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFinanzas;
        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdLogIn;
    }
}