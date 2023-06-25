
namespace Ej8_radar
{
    partial class FormControl
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.tbVelocidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEsCivil = new System.Windows.Forms.RadioButton();
            this.rbEsOficial = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnAgregarVehiculo);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 276);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de vehículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPatente);
            this.groupBox2.Controls.Add(this.tbVelocidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del vehículo";
            // 
            // tbPatente
            // 
            this.tbPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatente.Location = new System.Drawing.Point(93, 24);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(116, 26);
            this.tbPatente.TabIndex = 2;
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVelocidad.Location = new System.Drawing.Point(93, 57);
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(116, 26);
            this.tbVelocidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velocidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patente";
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(10, 218);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(92, 49);
            this.btnAgregarVehiculo.TabIndex = 9;
            this.btnAgregarVehiculo.Text = "Aceptar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEsCivil);
            this.groupBox3.Controls.Add(this.rbEsOficial);
            this.groupBox3.Location = new System.Drawing.Point(6, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 95);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de vehículo";
            // 
            // rbEsCivil
            // 
            this.rbEsCivil.AutoSize = true;
            this.rbEsCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEsCivil.Location = new System.Drawing.Point(23, 49);
            this.rbEsCivil.Name = "rbEsCivil";
            this.rbEsCivil.Size = new System.Drawing.Size(153, 24);
            this.rbEsCivil.TabIndex = 7;
            this.rbEsCivil.TabStop = true;
            this.rbEsCivil.Text = "¿Es vehículo civil?";
            this.rbEsCivil.UseVisualStyleBackColor = true;
            // 
            // rbEsOficial
            // 
            this.rbEsOficial.AutoSize = true;
            this.rbEsOficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEsOficial.Location = new System.Drawing.Point(23, 19);
            this.rbEsOficial.Name = "rbEsOficial";
            this.rbEsOficial.Size = new System.Drawing.Size(169, 24);
            this.rbEsOficial.TabIndex = 6;
            this.rbEsOficial.TabStop = true;
            this.rbEsOficial.Text = "¿Es vehículo oficial?";
            this.rbEsOficial.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 286);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormControl";
            this.Text = "Agregar Control";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbPatente;
        public System.Windows.Forms.TextBox tbVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rbEsCivil;
        public System.Windows.Forms.RadioButton rbEsOficial;
        private System.Windows.Forms.Button button1;
    }
}