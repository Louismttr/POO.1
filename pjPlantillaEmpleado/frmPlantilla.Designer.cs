namespace pjPlantillaEmpleado
{
    partial class frmPlantilla
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblComission = new System.Windows.Forms.Label();
            this.lblGratificacion = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSeguroSocial = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalIngreso = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalAportaciones = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planilla pago de empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAños);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(52, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información general del empleado";
            // 
            // txtAños
            // 
            this.txtAños.Enabled = false;
            this.txtAños.Location = new System.Drawing.Point(565, 102);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 23);
            this.txtAños.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Años de servicio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(565, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de consulta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes consultado:";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(399, 102);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 23);
            this.txtMes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(400, 46);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(100, 23);
            this.dtFechaIngreso.TabIndex = 4;
            this.dtFechaIngreso.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Coordinador",
            "Jefe",
            "Capacitador",
            "Asistente",
            "          "});
            this.cboCargo.Location = new System.Drawing.Point(14, 102);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(222, 23);
            this.cboCargo.TabIndex = 3;
            this.cboCargo.Text = "(Seleccione cargo)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(14, 46);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(355, 23);
            this.txtEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(54, 228);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblComission);
            this.groupBox2.Controls.Add(this.lblGratificacion);
            this.groupBox2.Controls.Add(this.lblSueldoBasico);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(52, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos";
            // 
            // lblComission
            // 
            this.lblComission.AutoSize = true;
            this.lblComission.Location = new System.Drawing.Point(179, 67);
            this.lblComission.Name = "lblComission";
            this.lblComission.Size = new System.Drawing.Size(44, 15);
            this.lblComission.TabIndex = 5;
            this.lblComission.Text = "label14";
            // 
            // lblGratificacion
            // 
            this.lblGratificacion.AutoSize = true;
            this.lblGratificacion.Location = new System.Drawing.Point(179, 43);
            this.lblGratificacion.Name = "lblGratificacion";
            this.lblGratificacion.Size = new System.Drawing.Size(44, 15);
            this.lblGratificacion.TabIndex = 4;
            this.lblGratificacion.Text = "label13";
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Location = new System.Drawing.Point(179, 19);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(44, 15);
            this.lblSueldoBasico.TabIndex = 3;
            this.lblSueldoBasico.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Comisión:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gratificación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Suledo Baásico:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCooperativa);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(316, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descuento";
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Location = new System.Drawing.Point(125, 19);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(44, 15);
            this.lblCooperativa.TabIndex = 1;
            this.lblCooperativa.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cooperativa:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSeguroSocial);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(554, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aportaciones";
            // 
            // lblSeguroSocial
            // 
            this.lblSeguroSocial.AutoSize = true;
            this.lblSeguroSocial.Location = new System.Drawing.Point(150, 19);
            this.lblSeguroSocial.Name = "lblSeguroSocial";
            this.lblSeguroSocial.Size = new System.Drawing.Size(44, 15);
            this.lblSeguroSocial.TabIndex = 1;
            this.lblSeguroSocial.Text = "label23";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Seguro social:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Total ingreso:";
            // 
            // lblTotalIngreso
            // 
            this.lblTotalIngreso.AutoSize = true;
            this.lblTotalIngreso.Location = new System.Drawing.Point(231, 388);
            this.lblTotalIngreso.Name = "lblTotalIngreso";
            this.lblTotalIngreso.Size = new System.Drawing.Size(44, 15);
            this.lblTotalIngreso.TabIndex = 7;
            this.lblTotalIngreso.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(316, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Total descuento:";
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Location = new System.Drawing.Point(472, 388);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(44, 15);
            this.lblTotalDescuento.TabIndex = 9;
            this.lblTotalDescuento.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(554, 388);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "Total aprortaciones:";
            // 
            // lblTotalAportaciones
            // 
            this.lblTotalAportaciones.AutoSize = true;
            this.lblTotalAportaciones.Location = new System.Drawing.Point(710, 388);
            this.lblTotalAportaciones.Name = "lblTotalAportaciones";
            this.lblTotalAportaciones.Size = new System.Drawing.Size(44, 15);
            this.lblTotalAportaciones.TabIndex = 11;
            this.lblTotalAportaciones.Text = "label24";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(52, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(554, 422);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 15);
            this.label25.TabIndex = 15;
            this.label25.Text = "Total Neto:";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Location = new System.Drawing.Point(713, 417);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(44, 15);
            this.lblTotalNeto.TabIndex = 16;
            this.lblTotalNeto.Text = "label26";
            // 
            // frmPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalNeto);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotalAportaciones);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTotalDescuento);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTotalIngreso);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPlantilla";
            this.Text = "Control de planilla de pago";
            this.Load += new System.EventHandler(this.frmPlantilla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAños;
        private Label label8;
        private Label lblFecha;
        private Label label6;
        private Label label5;
        private TextBox txtMes;
        private Label label4;
        private DateTimePicker dtFechaIngreso;
        private ComboBox cboCargo;
        private Label label3;
        private TextBox txtEmpleado;
        private Label label2;
        private Button btnProcesar;
        private GroupBox groupBox2;
        private Label lblComission;
        private Label lblGratificacion;
        private Label lblSueldoBasico;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox3;
        private Label lblCooperativa;
        private Label label15;
        private GroupBox groupBox4;
        private Label lblSeguroSocial;
        private Label label22;
        private Label label17;
        private Label lblTotalIngreso;
        private Label label19;
        private Label lblTotalDescuento;
        private Label label21;
        private Label lblTotalAportaciones;
        private Button btnSalir;
        private Button btnCancelar;
        private Label label25;
        private Label lblTotalNeto;
    }
}