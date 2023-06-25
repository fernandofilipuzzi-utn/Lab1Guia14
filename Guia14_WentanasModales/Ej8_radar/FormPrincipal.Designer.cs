
namespace Ej8_radar
{
    partial class FormPrincipal
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
            this.lbtInforme = new System.Windows.Forms.ListBox();
            this.btnListarInfractores = new System.Windows.Forms.Button();
            this.tbPatenteBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarInfractor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtInforme
            // 
            this.lbtInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtInforme.FormattingEnabled = true;
            this.lbtInforme.ItemHeight = 20;
            this.lbtInforme.Location = new System.Drawing.Point(6, 108);
            this.lbtInforme.Name = "lbtInforme";
            this.lbtInforme.Size = new System.Drawing.Size(276, 164);
            this.lbtInforme.TabIndex = 1;
            // 
            // btnListarInfractores
            // 
            this.btnListarInfractores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarInfractores.Location = new System.Drawing.Point(295, 108);
            this.btnListarInfractores.Name = "btnListarInfractores";
            this.btnListarInfractores.Size = new System.Drawing.Size(113, 52);
            this.btnListarInfractores.TabIndex = 2;
            this.btnListarInfractores.Text = "Listar Infractores";
            this.btnListarInfractores.UseVisualStyleBackColor = true;
            this.btnListarInfractores.Click += new System.EventHandler(this.btnListarInfractores_Click);
            // 
            // tbPatenteBuscar
            // 
            this.tbPatenteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatenteBuscar.Location = new System.Drawing.Point(90, 19);
            this.tbPatenteBuscar.Name = "tbPatenteBuscar";
            this.tbPatenteBuscar.Size = new System.Drawing.Size(139, 31);
            this.tbPatenteBuscar.TabIndex = 3;
            // 
            // btnBuscarInfractor
            // 
            this.btnBuscarInfractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInfractor.Location = new System.Drawing.Point(289, 11);
            this.btnBuscarInfractor.Name = "btnBuscarInfractor";
            this.btnBuscarInfractor.Size = new System.Drawing.Size(113, 53);
            this.btnBuscarInfractor.TabIndex = 4;
            this.btnBuscarInfractor.Text = "Buscar Infractor";
            this.btnBuscarInfractor.UseVisualStyleBackColor = true;
            this.btnBuscarInfractor.Click += new System.EventHandler(this.btnBuscarInfractor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPatenteBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarInfractor);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de infractores por patente";
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(282, 3);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(144, 49);
            this.btnAgregarVehiculo.TabIndex = 9;
            this.btnAgregarVehiculo.Text = "Agregar Control";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.lbtInforme);
            this.groupBox5.Controls.Add(this.btnListarInfractores);
            this.groupBox5.Location = new System.Drawing.Point(12, 58);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 276);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de vehículo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 337);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Control radarizado ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbtInforme;
        private System.Windows.Forms.Button btnListarInfractores;
        private System.Windows.Forms.TextBox tbPatenteBuscar;
        private System.Windows.Forms.Button btnBuscarInfractor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

