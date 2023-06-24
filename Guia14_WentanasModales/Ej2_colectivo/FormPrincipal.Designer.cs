
namespace Ej2_colectivo
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIngresadaParada = new System.Windows.Forms.Button();
            this.gbFinalizar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMLLegada = new System.Windows.Forms.TextBox();
            this.tbHLLegada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(278, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Viaje";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIngresadaParada
            // 
            this.btnIngresadaParada.Location = new System.Drawing.Point(12, 43);
            this.btnIngresadaParada.Name = "btnIngresadaParada";
            this.btnIngresadaParada.Size = new System.Drawing.Size(278, 23);
            this.btnIngresadaParada.TabIndex = 5;
            this.btnIngresadaParada.Text = "Ingresada Parada";
            this.btnIngresadaParada.UseVisualStyleBackColor = true;
            this.btnIngresadaParada.Click += new System.EventHandler(this.btnIngresadaParada_Click);
            // 
            // gbFinalizar
            // 
            this.gbFinalizar.Controls.Add(this.label11);
            this.gbFinalizar.Controls.Add(this.tbMLLegada);
            this.gbFinalizar.Controls.Add(this.tbHLLegada);
            this.gbFinalizar.Controls.Add(this.btnFinalizar);
            this.gbFinalizar.Controls.Add(this.label8);
            this.gbFinalizar.Enabled = false;
            this.gbFinalizar.Location = new System.Drawing.Point(12, 72);
            this.gbFinalizar.Name = "gbFinalizar";
            this.gbFinalizar.Size = new System.Drawing.Size(278, 76);
            this.gbFinalizar.TabIndex = 1;
            this.gbFinalizar.TabStop = false;
            this.gbFinalizar.Text = "Finalizar Parada";
            this.gbFinalizar.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = ":";
            // 
            // tbMLLegada
            // 
            this.tbMLLegada.Location = new System.Drawing.Point(220, 19);
            this.tbMLLegada.Name = "tbMLLegada";
            this.tbMLLegada.Size = new System.Drawing.Size(37, 20);
            this.tbMLLegada.TabIndex = 11;
            this.tbMLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHLLegada
            // 
            this.tbHLLegada.Location = new System.Drawing.Point(161, 19);
            this.tbHLLegada.Name = "tbHLLegada";
            this.tbHLLegada.Size = new System.Drawing.Size(37, 20);
            this.tbHLLegada.TabIndex = 12;
            this.tbHLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hora de Finalización (HH:MM)";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(132, 45);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(140, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Viaje";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 157);
            this.Controls.Add(this.gbFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnIngresadaParada);
            this.Name = "FormPrincipal";
            this.Text = "Empresa de viajes";
            this.gbFinalizar.ResumeLayout(false);
            this.gbFinalizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIngresadaParada;
        private System.Windows.Forms.GroupBox gbFinalizar;
        private System.Windows.Forms.TextBox tbMLLegada;
        private System.Windows.Forms.TextBox tbHLLegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label11;
    }
}

