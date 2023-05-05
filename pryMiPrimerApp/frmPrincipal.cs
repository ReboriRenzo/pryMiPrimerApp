using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena v = new frmAlacena();

            v.ShowDialog();

        }

        private void cmdFinanzas_Click(object sender, EventArgs e)
        {
            frmGestiónDeGastosMensuales ventanaGestiónDeGastosMensuales = new frmGestiónDeGastosMensuales();

            ventanaGestiónDeGastosMensuales.ShowDialog();


        }
    }
}
