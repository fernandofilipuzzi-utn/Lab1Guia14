﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_Encuesta
{
    public partial class FormRegistroDeEncuesta : Form
    {
        public FormRegistroDeEncuesta()
        {
            InitializeComponent();
        }

        private void chkPuedeSerContactado_CheckedChanged(object sender, EventArgs e)
        {
            tbEmail.Enabled = chkPuedeSerContactado.Checked;
        }

        private void tbDistanciaASuDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' ||
               char.IsControl(e.KeyChar))
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
