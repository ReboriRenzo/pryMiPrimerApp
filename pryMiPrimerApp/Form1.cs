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
    public partial class frmGestiónDeGastosMensuales : Form
    {
        private decimal varAlquiler;
        private decimal varImpuestos;
        private decimal varComidas;
        private decimal varSalidas;
        private decimal varDeposito;

        public frmGestiónDeGastosMensuales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestiónDeGastosMensuales_Load(object sender, EventArgs e)
        {
            //declaracion de variables

            decimal varDepositos, varAlquiler, varImpuestos, varComidas, varSalidas;

            //inicializar variables

            varDepositos = 0;
            varAlquiler = 0;
            varImpuestos = 0;
            varComidas = 0;
            varSalidas = 0;


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComidas = Convert.ToDecimal(txtComidas.Text);
            varSalidas = Convert.ToDecimal(txtSalidas.Text);

            varSalidas = varDeposito - (varAlquiler + varImpuestos + varComidas + varSalidas);
            lblCalculo.Text = "Resultado: " + varSalidas.ToString();
           

            //concatenar

            lblCalculo.Text = "Resultado: " + varSalidas.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComidas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
