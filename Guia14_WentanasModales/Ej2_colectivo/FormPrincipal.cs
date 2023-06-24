using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2_colectivo
{

    public partial class FormPrincipal : Form
    {
        Viaje viaje;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormInicio fInicio = new FormInicio();

            if (fInicio.ShowDialog() == DialogResult.OK)
            {
                int hInicio = Convert.ToInt32(fInicio.tbHInicio.Text);
                int mInicio = Convert.ToInt32(fInicio.tbMInicio.Text);
                int asientos = Convert.ToInt32(fInicio.tbAsientos.Text);

                #region verificando
                bool correctoh = hInicio >= 0 && hInicio <= 23;
                if (correctoh == false)
                {
                    MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
                }

                bool correctom = mInicio >= 0 && mInicio <= 59;
                if (correctom == false)
                {
                    MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
                }
                #endregion

                if (correctoh && correctom)
                {
                    viaje = new Viaje(hInicio, mInicio, asientos);

                    #region limpiando controles
                    btnFinalizar.Enabled = true;
                    tbHLLegada.Enabled = true;
                    tbMLLegada.Enabled = true;
                    gbFinalizar.Enabled = true;
                    btnIngresadaParada.Enabled = true;
                    btnIniciar.Enabled = false;
                    tbHLLegada.Clear();
                    tbMLLegada.Clear();
                    #endregion
                }
                else 
                {
                    MessageBox.Show("Hubo un error en el ingreso de datos! vuelva a intentarlo.");
                }
            }
            else
            {
                MessageBox.Show("Ha cancelado el ingreso del inicio del viaje.");
            }
        }

        private void btnIngresadaParada_Click(object sender, EventArgs e)
        {
            FormParada fParada = new FormParada();

            if (fParada.ShowDialog() == DialogResult.OK)
            {
                int hLLegadaParada = Convert.ToInt32(fParada.tbHLLegadaParada.Text);
                int mLLegadaParada = Convert.ToInt32(fParada.tbMLLegadaParada.Text);

                int hSalidaParada = Convert.ToInt32(fParada.tbHSalidaParada.Text);
                int mSalidaParada = Convert.ToInt32(fParada.tbMSalidaParada.Text);

                int ascienden = Convert.ToInt32(fParada.tbAscienden.Text);
                int descienden = Convert.ToInt32(fParada.tbDescienden.Text);

                #region verificando
                bool correctohLL = hLLegadaParada >= 0 && hLLegadaParada <= 23;
                if (correctohLL == false)
                {
                    MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
                }

                bool correctomLL = mLLegadaParada >= 0 && mLLegadaParada <= 59;
                if (correctomLL == false)
                {
                    MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
                }

                bool correctohS = hSalidaParada >= 0 && hSalidaParada <= 23;
                if (correctohS == false)
                {
                    MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
                }

                bool correctomS = mSalidaParada >= 0 && mSalidaParada <= 59;
                if (correctomS == false)
                {
                    MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
                }
                #endregion

                if (correctohLL && correctomLL && correctohS && correctomS)
                {
                    viaje.RealizarParada(hLLegadaParada, mLLegadaParada,
                                        hSalidaParada, mSalidaParada,
                                        ascienden, descienden);
                }
                else
                {
                    MessageBox.Show("Hubo un error en el ingreso de datos! vuelva a intentarlo.");
                }
            }
            else
            {
                MessageBox.Show("Ha cancelado el ingreso de la parada.");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int hLLegada = Convert.ToInt32(tbHLLegada.Text);
            int mLLegada = Convert.ToInt32(tbMLLegada.Text);

            #region verificando
            bool correctoh = hLLegada >= 0 && hLLegada <= 23;
            if (correctoh == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = mLLegada >= 0 && mLLegada <= 59;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }
            #endregion

            if (correctoh && correctom)
            {
                viaje.Finalizar(hLLegada, mLLegada);

                #region informando resultados
                
                FormInforme fInforme = new FormInforme();

                fInforme.ltbResultados.Items.Clear();
                fInforme.ltbResultados.Items.Add($"Cantidad de pasajeros transportados: {viaje.PasajerosTrasnportados}");
                fInforme.ltbResultados.Items.Add($"Tiempo total de recorrido: {viaje.HDuracionViaje,00}:{viaje.MDuracionViaje,00}");
                fInforme.ltbResultados.Items.Add($"Cantidad de paradas: {viaje.CantParadas}");
                fInforme.ltbResultados.Items.Add($"Tiempo total de demora en las paradas: {viaje.HDemora,00}:{viaje.MDemora,00}");

                fInforme.ShowDialog();
                #endregion

                #region limpiando controles
                btnFinalizar.Enabled = false;
                tbHLLegada.Enabled = false;
                tbMLLegada.Enabled = false;
                btnIngresadaParada.Enabled = false;
                btnIniciar.Enabled = true;
                #endregion
            }
        }

        private void tbPositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)  || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
