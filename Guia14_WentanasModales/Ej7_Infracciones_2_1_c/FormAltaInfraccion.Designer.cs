
namespace Ej7_Infracciones_2_1_c
{
    partial class FormAltaInfraccion
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
            this.gbActa = new System.Windows.Forms.GroupBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.chbPagaLugar = new System.Windows.Forms.CheckBox();
            this.gbTipoInfraccion = new System.Windows.Forms.GroupBox();
            this.cbmInfracciones = new System.Windows.Forms.ComboBox();
            this.btnAgregarInfraccion = new System.Windows.Forms.Button();
            this.gbTipoVehiculo = new System.Windows.Forms.GroupBox();
            this.rbEje2 = new System.Windows.Forms.RadioButton();
            this.rbEje3 = new System.Windows.Forms.RadioButton();
            this.rbEje1 = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbConductor = new System.Windows.Forms.GroupBox();
            this.btnIniciarActa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbActa.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbTipoInfraccion.SuspendLayout();
            this.gbTipoVehiculo.SuspendLayout();
            this.gbConductor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActa
            // 
            this.gbActa.Controls.Add(this.gbPago);
            this.gbActa.Controls.Add(this.gbTipoInfraccion);
            this.gbActa.Controls.Add(this.gbTipoVehiculo);
            this.gbActa.Controls.Add(this.gbConductor);
            this.gbActa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActa.Location = new System.Drawing.Point(12, 12);
            this.gbActa.Name = "gbActa";
            this.gbActa.Size = new System.Drawing.Size(400, 351);
            this.gbActa.TabIndex = 2;
            this.gbActa.TabStop = false;
            this.gbActa.Text = "Acta";
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.chbPagaLugar);
            this.gbPago.Enabled = false;
            this.gbPago.Location = new System.Drawing.Point(6, 294);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(388, 46);
            this.gbPago.TabIndex = 10;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // chbPagaLugar
            // 
            this.chbPagaLugar.AutoSize = true;
            this.chbPagaLugar.Location = new System.Drawing.Point(79, 18);
            this.chbPagaLugar.Name = "chbPagaLugar";
            this.chbPagaLugar.Size = new System.Drawing.Size(147, 21);
            this.chbPagaLugar.TabIndex = 0;
            this.chbPagaLugar.Text = "¿Paga en el lugar?";
            this.chbPagaLugar.UseVisualStyleBackColor = true;
            // 
            // gbTipoInfraccion
            // 
            this.gbTipoInfraccion.Controls.Add(this.cbmInfracciones);
            this.gbTipoInfraccion.Controls.Add(this.btnAgregarInfraccion);
            this.gbTipoInfraccion.Enabled = false;
            this.gbTipoInfraccion.Location = new System.Drawing.Point(6, 212);
            this.gbTipoInfraccion.Name = "gbTipoInfraccion";
            this.gbTipoInfraccion.Size = new System.Drawing.Size(388, 76);
            this.gbTipoInfraccion.TabIndex = 7;
            this.gbTipoInfraccion.TabStop = false;
            this.gbTipoInfraccion.Text = "Tipo de Infracción";
            // 
            // cbmInfracciones
            // 
            this.cbmInfracciones.FormattingEnabled = true;
            this.cbmInfracciones.Location = new System.Drawing.Point(24, 29);
            this.cbmInfracciones.Name = "cbmInfracciones";
            this.cbmInfracciones.Size = new System.Drawing.Size(260, 24);
            this.cbmInfracciones.TabIndex = 9;
            // 
            // btnAgregarInfraccion
            // 
            this.btnAgregarInfraccion.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnAgregarInfraccion.Location = new System.Drawing.Point(290, 13);
            this.btnAgregarInfraccion.Name = "btnAgregarInfraccion";
            this.btnAgregarInfraccion.Size = new System.Drawing.Size(92, 55);
            this.btnAgregarInfraccion.TabIndex = 8;
            this.btnAgregarInfraccion.Text = "Agregar Infracción";
            this.btnAgregarInfraccion.UseVisualStyleBackColor = true;
            // 
            // gbTipoVehiculo
            // 
            this.gbTipoVehiculo.Controls.Add(this.rbEje2);
            this.gbTipoVehiculo.Controls.Add(this.rbEje3);
            this.gbTipoVehiculo.Controls.Add(this.rbEje1);
            this.gbTipoVehiculo.Location = new System.Drawing.Point(12, 99);
            this.gbTipoVehiculo.Name = "gbTipoVehiculo";
            this.gbTipoVehiculo.Size = new System.Drawing.Size(278, 97);
            this.gbTipoVehiculo.TabIndex = 6;
            this.gbTipoVehiculo.TabStop = false;
            this.gbTipoVehiculo.Text = "Tipo de vehículo";
            // 
            // rbEje2
            // 
            this.rbEje2.AutoSize = true;
            this.rbEje2.Location = new System.Drawing.Point(90, 42);
            this.rbEje2.Name = "rbEje2";
            this.rbEje2.Size = new System.Drawing.Size(139, 21);
            this.rbEje2.TabIndex = 2;
            this.rbEje2.TabStop = true;
            this.rbEje2.Text = "2 Ejes (automovil)";
            this.rbEje2.UseVisualStyleBackColor = true;
            // 
            // rbEje3
            // 
            this.rbEje3.AutoSize = true;
            this.rbEje3.Location = new System.Drawing.Point(90, 65);
            this.rbEje3.Name = "rbEje3";
            this.rbEje3.Size = new System.Drawing.Size(122, 21);
            this.rbEje3.TabIndex = 1;
            this.rbEje3.TabStop = true;
            this.rbEje3.Text = "3 o más (otros)";
            this.rbEje3.UseVisualStyleBackColor = true;
            // 
            // rbEje1
            // 
            this.rbEje1.AutoSize = true;
            this.rbEje1.Location = new System.Drawing.Point(90, 19);
            this.rbEje1.Name = "rbEje1";
            this.rbEje1.Size = new System.Drawing.Size(103, 21);
            this.rbEje1.TabIndex = 0;
            this.rbEje1.TabStop = true;
            this.rbEje1.Text = "1 Eje (moto)";
            this.rbEje1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(65, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 52);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Registrar Acta";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gbConductor
            // 
            this.gbConductor.Controls.Add(this.btnIniciarActa);
            this.gbConductor.Controls.Add(this.label1);
            this.gbConductor.Controls.Add(this.tbNombre);
            this.gbConductor.Controls.Add(this.label2);
            this.gbConductor.Controls.Add(this.tbDni);
            this.gbConductor.Location = new System.Drawing.Point(6, 22);
            this.gbConductor.Name = "gbConductor";
            this.gbConductor.Size = new System.Drawing.Size(388, 184);
            this.gbConductor.TabIndex = 5;
            this.gbConductor.TabStop = false;
            this.gbConductor.Text = "Conductor:";
            // 
            // btnIniciarActa
            // 
            this.btnIniciarActa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnIniciarActa.Location = new System.Drawing.Point(290, 119);
            this.btnIniciarActa.Name = "btnIniciarActa";
            this.btnIniciarActa.Size = new System.Drawing.Size(92, 52);
            this.btnIniciarActa.TabIndex = 5;
            this.btnIniciarActa.Text = "Iniciar Acta";
            this.btnIniciarActa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(124, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 23);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(124, 19);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(160, 23);
            this.tbDni.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(229, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAltaInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 429);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbActa);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FormAltaInfraccion";
            this.Text = "Registro de infracción";
            this.gbActa.ResumeLayout(false);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbTipoInfraccion.ResumeLayout(false);
            this.gbTipoVehiculo.ResumeLayout(false);
            this.gbTipoVehiculo.PerformLayout();
            this.gbConductor.ResumeLayout(false);
            this.gbConductor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarInfraccion;
        private System.Windows.Forms.Button btnIniciarActa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox chbPagaLugar;
        public System.Windows.Forms.ComboBox cbmInfracciones;
        public System.Windows.Forms.RadioButton rbEje2;
        public System.Windows.Forms.RadioButton rbEje3;
        public System.Windows.Forms.RadioButton rbEje1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDni;
        public System.Windows.Forms.GroupBox gbActa;
        public System.Windows.Forms.GroupBox gbPago;
        public System.Windows.Forms.GroupBox gbTipoInfraccion;
        public System.Windows.Forms.GroupBox gbConductor;
        public System.Windows.Forms.GroupBox gbTipoVehiculo;
    }
}