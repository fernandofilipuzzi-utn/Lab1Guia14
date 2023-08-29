
namespace Ej3_Concesionaria_2_2
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
            this.btnIniciarEmbarque = new System.Windows.Forms.Button();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.btnListadoEmbarques = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmbarquePorNumero = new System.Windows.Forms.Button();
            this.tbNumeroEmbBusq = new System.Windows.Forms.TextBox();
            this.btnEmbarqueMayor = new System.Windows.Forms.Button();
            this.ltbInforme = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.gbInforme.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarEmbarque
            // 
            this.btnIniciarEmbarque.Location = new System.Drawing.Point(188, 7);
            this.btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            this.btnIniciarEmbarque.Size = new System.Drawing.Size(163, 41);
            this.btnIniciarEmbarque.TabIndex = 3;
            this.btnIniciarEmbarque.Text = "Alta Embarque";
            this.btnIniciarEmbarque.UseVisualStyleBackColor = true;
            this.btnIniciarEmbarque.Click += new System.EventHandler(this.btnIniciarEmbarque_Click);
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.btnListadoEmbarques);
            this.gbInforme.Controls.Add(this.groupBox5);
            this.gbInforme.Controls.Add(this.btnEmbarqueMayor);
            this.gbInforme.Controls.Add(this.ltbInforme);
            this.gbInforme.Controls.Add(this.btnRecaudacion);
            this.gbInforme.Enabled = false;
            this.gbInforme.Location = new System.Drawing.Point(12, 48);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(546, 278);
            this.gbInforme.TabIndex = 2;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informe";
            // 
            // btnListadoEmbarques
            // 
            this.btnListadoEmbarques.Location = new System.Drawing.Point(465, 171);
            this.btnListadoEmbarques.Name = "btnListadoEmbarques";
            this.btnListadoEmbarques.Size = new System.Drawing.Size(75, 36);
            this.btnListadoEmbarques.TabIndex = 14;
            this.btnListadoEmbarques.Text = "Todos los embarues";
            this.btnListadoEmbarques.UseVisualStyleBackColor = true;
            this.btnListadoEmbarques.Click += new System.EventHandler(this.btnListadoEmbarques_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnEmbarquePorNumero);
            this.groupBox5.Controls.Add(this.tbNumeroEmbBusq);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(534, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver Embarque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número embarque";
            // 
            // btnEmbarquePorNumero
            // 
            this.btnEmbarquePorNumero.Location = new System.Drawing.Point(369, 15);
            this.btnEmbarquePorNumero.Name = "btnEmbarquePorNumero";
            this.btnEmbarquePorNumero.Size = new System.Drawing.Size(150, 31);
            this.btnEmbarquePorNumero.TabIndex = 10;
            this.btnEmbarquePorNumero.Text = "Buscar Embarque";
            this.btnEmbarquePorNumero.UseVisualStyleBackColor = true;
            this.btnEmbarquePorNumero.Click += new System.EventHandler(this.btnEmbarquePorNumero_Click);
            // 
            // tbNumeroEmbBusq
            // 
            this.tbNumeroEmbBusq.Location = new System.Drawing.Point(117, 21);
            this.tbNumeroEmbBusq.Name = "tbNumeroEmbBusq";
            this.tbNumeroEmbBusq.Size = new System.Drawing.Size(231, 20);
            this.tbNumeroEmbBusq.TabIndex = 9;
            // 
            // btnEmbarqueMayor
            // 
            this.btnEmbarqueMayor.Location = new System.Drawing.Point(465, 129);
            this.btnEmbarqueMayor.Name = "btnEmbarqueMayor";
            this.btnEmbarqueMayor.Size = new System.Drawing.Size(75, 36);
            this.btnEmbarqueMayor.TabIndex = 13;
            this.btnEmbarqueMayor.Text = "Embarque Mayor";
            this.btnEmbarqueMayor.UseVisualStyleBackColor = true;
            this.btnEmbarqueMayor.Click += new System.EventHandler(this.btnEmbarqueMayor_Click);
            // 
            // ltbInforme
            // 
            this.ltbInforme.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbInforme.FormattingEnabled = true;
            this.ltbInforme.ItemHeight = 16;
            this.ltbInforme.Location = new System.Drawing.Point(6, 87);
            this.ltbInforme.Name = "ltbInforme";
            this.ltbInforme.Size = new System.Drawing.Size(453, 180);
            this.ltbInforme.TabIndex = 11;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(465, 87);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(75, 36);
            this.btnRecaudacion.TabIndex = 12;
            this.btnRecaudacion.Text = "Resumen del día";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 331);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.btnIniciarEmbarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "Mi concesionaria";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbInforme.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarEmbarque;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Button btnListadoEmbarques;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEmbarquePorNumero;
        private System.Windows.Forms.TextBox tbNumeroEmbBusq;
        private System.Windows.Forms.Button btnEmbarqueMayor;
        private System.Windows.Forms.ListBox ltbInforme;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Label label5;
    }
}

