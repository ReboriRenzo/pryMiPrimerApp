namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            this.txtAlmacen = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.chkLimpieza = new System.Windows.Forms.CheckBox();
            this.chkComida = new System.Windows.Forms.CheckBox();
            this.chkBebidas = new System.Windows.Forms.CheckBox();
            this.txtFechaDeVencimiento = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.txtLugar = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.txtAlmacen.SuspendLayout();
            this.txtFechaDeVencimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Controls.Add(this.nudCantidad);
            this.txtAlmacen.Controls.Add(this.chkBebidas);
            this.txtAlmacen.Controls.Add(this.chkComida);
            this.txtAlmacen.Controls.Add(this.chkLimpieza);
            this.txtAlmacen.Controls.Add(this.lstLugar);
            this.txtAlmacen.Controls.Add(this.lstProducto);
            this.txtAlmacen.Controls.Add(this.txtCantidad);
            this.txtAlmacen.Controls.Add(this.txtProducto);
            this.txtAlmacen.Controls.Add(this.txtLugar);
            this.txtAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacen.Location = new System.Drawing.Point(12, 12);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(310, 117);
            this.txtAlmacen.TabIndex = 0;
            this.txtAlmacen.TabStop = false;
            this.txtAlmacen.Text = "Almacen";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(116, 30);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(81, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Producto";
            this.txtProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(208, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstProducto
            // 
            this.lstProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Items.AddRange(new object[] {
            "Lavandina",
            "Coca Cola",
            "Fanta",
            "Tallarines",
            "Carne",
            "Trapos de piso"});
            this.lstProducto.Location = new System.Drawing.Point(109, 53);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(97, 28);
            this.lstProducto.TabIndex = 3;
            // 
            // chkLimpieza
            // 
            this.chkLimpieza.AutoSize = true;
            this.chkLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLimpieza.Location = new System.Drawing.Point(15, 91);
            this.chkLimpieza.Name = "chkLimpieza";
            this.chkLimpieza.Size = new System.Drawing.Size(75, 17);
            this.chkLimpieza.TabIndex = 5;
            this.chkLimpieza.Text = "Limpieza";
            this.chkLimpieza.UseVisualStyleBackColor = true;
            this.chkLimpieza.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkComida
            // 
            this.chkComida.AutoSize = true;
            this.chkComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComida.Location = new System.Drawing.Point(109, 91);
            this.chkComida.Name = "chkComida";
            this.chkComida.Size = new System.Drawing.Size(67, 17);
            this.chkComida.TabIndex = 6;
            this.chkComida.Text = "Comida";
            this.chkComida.UseVisualStyleBackColor = true;
            // 
            // chkBebidas
            // 
            this.chkBebidas.AutoSize = true;
            this.chkBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBebidas.Location = new System.Drawing.Point(212, 91);
            this.chkBebidas.Name = "chkBebidas";
            this.chkBebidas.Size = new System.Drawing.Size(71, 17);
            this.chkBebidas.TabIndex = 7;
            this.chkBebidas.Text = "Bebidas";
            this.chkBebidas.UseVisualStyleBackColor = true;
            // 
            // txtFechaDeVencimiento
            // 
            this.txtFechaDeVencimiento.Controls.Add(this.dtpFechaDeVencimiento);
            this.txtFechaDeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDeVencimiento.Location = new System.Drawing.Point(12, 135);
            this.txtFechaDeVencimiento.Name = "txtFechaDeVencimiento";
            this.txtFechaDeVencimiento.Size = new System.Drawing.Size(310, 72);
            this.txtFechaDeVencimiento.TabIndex = 1;
            this.txtFechaDeVencimiento.TabStop = false;
            this.txtFechaDeVencimiento.Text = "Fecha de Vencimiento";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(212, 56);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(83, 26);
            this.nudCantidad.TabIndex = 8;
            // 
            // dtpFechaDeVencimiento
            // 
            this.dtpFechaDeVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeVencimiento.Location = new System.Drawing.Point(12, 40);
            this.dtpFechaDeVencimiento.Name = "dtpFechaDeVencimiento";
            this.dtpFechaDeVencimiento.Size = new System.Drawing.Size(292, 26);
            this.dtpFechaDeVencimiento.TabIndex = 0;
            // 
            // lstLugar
            // 
            this.lstLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Items.AddRange(new object[] {
            "Lavanderia",
            "Almacen",
            "Heladera"});
            this.lstLugar.Location = new System.Drawing.Point(6, 53);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(97, 28);
            this.lstLugar.TabIndex = 4;
            this.lstLugar.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(21, 30);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(55, 20);
            this.txtLugar.TabIndex = 0;
            this.txtLugar.Text = "Lugar";
            this.txtLugar.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(151, 213);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 33);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(232, 213);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 33);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 256);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(310, 121);
            this.Lista.TabIndex = 4;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 385);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtFechaDeVencimiento);
            this.Controls.Add(this.txtAlmacen);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.txtAlmacen.ResumeLayout(false);
            this.txtAlmacen.PerformLayout();
            this.txtFechaDeVencimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtAlmacen;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.CheckBox chkLimpieza;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.CheckBox chkBebidas;
        private System.Windows.Forms.CheckBox chkComida;
        private System.Windows.Forms.GroupBox txtFechaDeVencimiento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaDeVencimiento;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.Label txtLugar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox Lista;
    }
}