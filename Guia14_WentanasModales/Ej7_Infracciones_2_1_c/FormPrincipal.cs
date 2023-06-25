using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej7_Infracciones_2_1_c
{
    public partial class FormPrincipal : Form
    {
        Sistema sistema;
        

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormInicioSistema fInicio = new FormInicioSistema();

            if (fInicio.ShowDialog() == DialogResult.OK)
            {
                double baseMonetaria = Convert.ToDouble(fInicio.tbBaseMonetaria.Text);
                sistema = new Sistema(baseMonetaria);
            }
        }

        private void btnIniciarSistema_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarActa_Click(object sender, EventArgs e)
        {
            FormAltaInfraccion fInfraccion = new FormAltaInfraccion();
            
            Acta nuevo=null;

            #region iniciando la modal!
            for (int n = 0; n < sistema.CantInfracciones; n++)
            {
                Infraccion infr = sistema.VerInfraccion(n);
                fInfraccion.cbmInfracciones.Items.Add($"{infr.Descripcion} + ({infr.Codigo})");
            }
            #endregion

            DialogResult result;            
            do{
                result = fInfraccion.ShowDialog();

                #region alta acta
                if (result == DialogResult.Yes)
                {
                    #region levantando datos de la ventana
                    int dni = Convert.ToInt32(fInfraccion.tbDni.Text);
                    string nombre = fInfraccion.tbNombre.Text;

                    int tipo = 0;
                    if (fInfraccion.rbEje1.Checked == true)
                        tipo = 1;
                    else if (fInfraccion.rbEje2.Checked == true)
                        tipo = 2;
                    else if (fInfraccion.rbEje1.Checked == true)
                        tipo = 3;
                    #endregion

                    nuevo = new Acta(dni, nombre, tipo, sistema.BaseMonetaria);

                    #region  limpiando controles
                    fInfraccion.gbConductor.Enabled = false;
                    fInfraccion.gbTipoVehiculo.Enabled = false;
                    fInfraccion.gbTipoInfraccion.Enabled = true;
                    fInfraccion.gbPago.Enabled = true;
                    #endregion
                }
                #endregion

                #region agregando infracciones
                if (result == DialogResult.Retry)
                {
                    if (fInfraccion.cbmInfracciones.SelectedIndex != -1)
                    {
                        int idx = fInfraccion.cbmInfracciones.SelectedIndex;
                        Infraccion selected = sistema.VerInfraccion(idx);

                        nuevo.Agregar(selected);

                        fInfraccion.cbmInfracciones.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un item!");
                    }
                }
                #endregion
            } while (result == DialogResult.Retry || result == DialogResult.Yes);

            #region cerrando y agregando el acta
            if (nuevo != null && result == DialogResult.OK)
            {
                nuevo.Finalizar(fInfraccion.chbPagaLugar.Checked);
                sistema.Agregar(nuevo);

                #region impresion de ticket
                lbxInforme.Items.Clear();
                lbxInforme.Items.Add("Ticket:");
                lbxInforme.Items.Add("--------------------------------------------");

                int lineas;
                string[] ticket = nuevo.VerTicket(out lineas);
                for (int n = 0; n < lineas; n++)
                {
                    lbxInforme.Items.Add(ticket[n]);
                }

                lbxInforme.Items.Add("--------------------------------------------");
                #endregion
            }
            #endregion
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            lbxInforme.Items.Add("Resumen del día\n");
            lbxInforme.Items.Add("--------------------------------------------");
            lbxInforme.Items.Add(string.Format("Recaudación: {0:f2}", sistema.Recaudacion));
            lbxInforme.Items.Add("--------------------------------------------");
        }

        private void btnMayorMonto_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            lbxInforme.Items.Add("Acta con mayor monto pagado\n");
            lbxInforme.Items.Add("--------------------------------------------");
            if (sistema.MayorMonto != null)
            {
                int lineas;
                string[] ticket = sistema.MayorMonto.VerTicket(out lineas);
                for (int n = 0; n < lineas; n++)
                {
                    lbxInforme.Items.Add(ticket[n]);
                }
            }
            else
            {
                lbxInforme.Items.Add("no hay registro de un acta");
            }
            lbxInforme.Items.Add("--------------------------------------------");           
        }

        private void btnListadoPagoEnLugar_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            sistema.OrdenarActasPorMonto();

            lbxInforme.Items.Add("Listado de actas que han pagado en el lugar");
            lbxInforme.Items.Add("--------------------------------------------");
            int nro = 1;
            for (int m = 0; m < sistema.CantActasRevisar; m++)
            {
                lbxInforme.Items.Add($"------ticket nro:{nro++}------------------------------");

                int lineas;
                string[] ticket = sistema.MayorMonto.VerTicket(out lineas);
                for (int n = 0; n < lineas; n++)
                {
                    lbxInforme.Items.Add(ticket[n]);
                }

                lbxInforme.Items.Add("-----------------------------------------------------");
                lbxInforme.Items.Add("");
            }
        }
    }
}
