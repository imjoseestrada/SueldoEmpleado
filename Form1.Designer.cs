namespace EscuelaGUI
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.rbPagoHoras = new System.Windows.Forms.RadioButton();
            this.rbTiempoCompleto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPagoHr = new System.Windows.Forms.TextBox();
            this.txtHorasTrab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldoMensual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.impresiones = new System.Windows.Forms.GroupBox();
            this.txtImpresiones = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.impresiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(127, 61);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(148, 20);
            this.txtDepartamento.TabIndex = 3;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(127, 87);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(148, 20);
            this.txtPuesto.TabIndex = 4;
            // 
            // rbPagoHoras
            // 
            this.rbPagoHoras.AutoSize = true;
            this.rbPagoHoras.Location = new System.Drawing.Point(287, 54);
            this.rbPagoHoras.Name = "rbPagoHoras";
            this.rbPagoHoras.Size = new System.Drawing.Size(99, 17);
            this.rbPagoHoras.TabIndex = 5;
            this.rbPagoHoras.TabStop = true;
            this.rbPagoHoras.Text = "Pago por Horas";
            this.rbPagoHoras.UseVisualStyleBackColor = true;
            this.rbPagoHoras.CheckedChanged += new System.EventHandler(this.rbPagoHoras_CheckedChanged);
            // 
            // rbTiempoCompleto
            // 
            this.rbTiempoCompleto.AutoSize = true;
            this.rbTiempoCompleto.Location = new System.Drawing.Point(287, 77);
            this.rbTiempoCompleto.Name = "rbTiempoCompleto";
            this.rbTiempoCompleto.Size = new System.Drawing.Size(107, 17);
            this.rbTiempoCompleto.TabIndex = 6;
            this.rbTiempoCompleto.TabStop = true;
            this.rbTiempoCompleto.Text = "Tiempo Completo";
            this.rbTiempoCompleto.UseVisualStyleBackColor = true;
            this.rbTiempoCompleto.CheckedChanged += new System.EventHandler(this.rbTiempoCompleto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPagoHr);
            this.panel1.Controls.Add(this.txtHorasTrab);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(34, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 142);
            this.panel1.TabIndex = 7;
            // 
            // txtPagoHr
            // 
            this.txtPagoHr.Location = new System.Drawing.Point(58, 97);
            this.txtPagoHr.Name = "txtPagoHr";
            this.txtPagoHr.Size = new System.Drawing.Size(129, 20);
            this.txtPagoHr.TabIndex = 3;
            // 
            // txtHorasTrab
            // 
            this.txtHorasTrab.Location = new System.Drawing.Point(58, 47);
            this.txtHorasTrab.Name = "txtHorasTrab";
            this.txtHorasTrab.Size = new System.Drawing.Size(129, 20);
            this.txtHorasTrab.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pago por hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Horas trabajadas:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSueldoMensual);
            this.panel2.Location = new System.Drawing.Point(34, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 142);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sueldo mensual:";
            // 
            // txtSueldoMensual
            // 
            this.txtSueldoMensual.Location = new System.Drawing.Point(73, 73);
            this.txtSueldoMensual.Name = "txtSueldoMensual";
            this.txtSueldoMensual.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoMensual.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(101, 282);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 24);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(419, 55);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 30);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Puesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de empleado:";
            // 
            // impresiones
            // 
            this.impresiones.Controls.Add(this.txtImpresiones);
            this.impresiones.Location = new System.Drawing.Point(287, 128);
            this.impresiones.Name = "impresiones";
            this.impresiones.Size = new System.Drawing.Size(238, 178);
            this.impresiones.TabIndex = 16;
            this.impresiones.TabStop = false;
            this.impresiones.Text = "Impresiones";
            // 
            // txtImpresiones
            // 
            this.txtImpresiones.Location = new System.Drawing.Point(6, 18);
            this.txtImpresiones.Multiline = true;
            this.txtImpresiones.Name = "txtImpresiones";
            this.txtImpresiones.ReadOnly = true;
            this.txtImpresiones.Size = new System.Drawing.Size(226, 154);
            this.txtImpresiones.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 341);
            this.Controls.Add(this.impresiones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbTiempoCompleto);
            this.Controls.Add(this.rbPagoHoras);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Sueldo del empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.impresiones.ResumeLayout(false);
            this.impresiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.RadioButton rbPagoHoras;
        private System.Windows.Forms.RadioButton rbTiempoCompleto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagoHr;
        private System.Windows.Forms.TextBox txtHorasTrab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldoMensual;
        private System.Windows.Forms.GroupBox impresiones;
        private System.Windows.Forms.TextBox txtImpresiones;
    }
}

