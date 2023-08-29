
namespace Ej3_Concesionaria_2_2
{
    partial class FormDatosEmbarque
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
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.btnIngresarVehiculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMontoFabricacion = new System.Windows.Forms.TextBox();
            this.tbAñoFabricacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbAltaEmbarque = new System.Windows.Forms.GroupBox();
            this.btnIniciarEmbarque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroEmbarque = new System.Windows.Forms.TextBox();
            this.gbVehiculo.SuspendLayout();
            this.gbAltaEmbarque.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.btnIngresarVehiculo);
            this.gbVehiculo.Controls.Add(this.label4);
            this.gbVehiculo.Controls.Add(this.label3);
            this.gbVehiculo.Controls.Add(this.tbMontoFabricacion);
            this.gbVehiculo.Controls.Add(this.tbAñoFabricacion);
            this.gbVehiculo.Enabled = false;
            this.gbVehiculo.Location = new System.Drawing.Point(12, 86);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(330, 77);
            this.gbVehiculo.TabIndex = 4;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehículo del embarque";
            // 
            // btnIngresarVehiculo
            // 
            this.btnIngresarVehiculo.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnIngresarVehiculo.Location = new System.Drawing.Point(225, 17);
            this.btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            this.btnIngresarVehiculo.Size = new System.Drawing.Size(94, 47);
            this.btnIngresarVehiculo.TabIndex = 6;
            this.btnIngresarVehiculo.Text = "Ingresar Vehiculo del embarque ingresante";
            this.btnIngresarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto de fabricación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año de fabricación";
            // 
            // tbMontoFabricacion
            // 
            this.tbMontoFabricacion.Location = new System.Drawing.Point(119, 44);
            this.tbMontoFabricacion.Name = "tbMontoFabricacion";
            this.tbMontoFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbMontoFabricacion.TabIndex = 5;
            // 
            // tbAñoFabricacion
            // 
            this.tbAñoFabricacion.Location = new System.Drawing.Point(119, 19);
            this.tbAñoFabricacion.Name = "tbAñoFabricacion";
            this.tbAñoFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbAñoFabricacion.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(41, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 40);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar y Terminar Proceso";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(199, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbAltaEmbarque
            // 
            this.gbAltaEmbarque.Controls.Add(this.btnIniciarEmbarque);
            this.gbAltaEmbarque.Controls.Add(this.label2);
            this.gbAltaEmbarque.Controls.Add(this.tbNroEmbarque);
            this.gbAltaEmbarque.Location = new System.Drawing.Point(12, 12);
            this.gbAltaEmbarque.Name = "gbAltaEmbarque";
            this.gbAltaEmbarque.Size = new System.Drawing.Size(330, 68);
            this.gbAltaEmbarque.TabIndex = 11;
            this.gbAltaEmbarque.TabStop = false;
            this.gbAltaEmbarque.Text = "Datos del embarque ingresante";
            // 
            // btnIniciarEmbarque
            // 
            this.btnIniciarEmbarque.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnIniciarEmbarque.Location = new System.Drawing.Point(225, 19);
            this.btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            this.btnIniciarEmbarque.Size = new System.Drawing.Size(94, 41);
            this.btnIniciarEmbarque.TabIndex = 4;
            this.btnIniciarEmbarque.Text = "Alta Embarque";
            this.btnIniciarEmbarque.UseVisualStyleBackColor = true;
            this.btnIniciarEmbarque.Click += new System.EventHandler(this.btnIniciarEmbarque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número embarque";
            // 
            // tbNroEmbarque
            // 
            this.tbNroEmbarque.Location = new System.Drawing.Point(119, 30);
            this.tbNroEmbarque.Name = "tbNroEmbarque";
            this.tbNroEmbarque.Size = new System.Drawing.Size(100, 20);
            this.tbNroEmbarque.TabIndex = 2;
            // 
            // FormDatosEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 217);
            this.Controls.Add(this.gbAltaEmbarque);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDatosEmbarque";
            this.Text = "Ingresando embarque a la concesionaria";
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.gbAltaEmbarque.ResumeLayout(false);
            this.gbAltaEmbarque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbMontoFabricacion;
        public System.Windows.Forms.TextBox tbAñoFabricacion;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnIngresarVehiculo;
        private System.Windows.Forms.GroupBox gbAltaEmbarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarEmbarque;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox tbNroEmbarque;
    }
}