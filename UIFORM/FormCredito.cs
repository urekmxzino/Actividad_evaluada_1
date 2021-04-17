using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFORM
{
    public partial class FormCredito : Form
    {
        public FormCredito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double monto = double.Parse(txtMonto.Text);
            int cuotas = int.Parse(txtCuotas.Text);
            prueba p1 = new prueba();
            if (monto >= 500000)
            {
                if (cuotas >=1 && cuotas<= 36)
                {
                    p1.monto_solicitado = monto;
                    p1.cantidad_cuota = cuotas;
                    p1.calcular_todo();
                    //MessageBox.Show("El valor de cada cuota es de: " + p1.valor_cuota + "\nEl monto total es de: " + p1.monto_total);
                    txtMontoTotal.Text = p1.monto_total.ToString();
                    txtValorcuotaa.Text = p1.valor_cuota.ToString();
                }
                    
                else
                {
                            MessageBox.Show("Error: Ingresa una cantidad de cuotas entre 1 y 36");
                            txtCuotas.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error: El monto solicitado debe ser mayor a $500.000 pesos");
                txtMonto.Clear();
            }
            

        }

        private void txtCuotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormCredito_Load(object sender, EventArgs e)
        {

        }

        private void txtValorcuotaa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
