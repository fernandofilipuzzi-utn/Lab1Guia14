using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3_Concesionaria_2_2
{
    public partial class FormDatosEmbarque : Form
    {
        public FormDatosEmbarque()
        {
            InitializeComponent();
        }

        private void btnIniciarEmbarque_Click(object sender, EventArgs e)
        {
            btnIngresarVehiculo.Enabled = true;
            gbAltaEmbarque.Enabled = false;

            gbVehiculo.Enabled = true;

            btnAceptar.Enabled = true;
        }
    }
}
