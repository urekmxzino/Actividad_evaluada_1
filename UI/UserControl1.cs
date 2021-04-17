using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
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
            p1.monto_solicitado = monto;
            p1.cantidad_cuota = cuotas;
            p1.calcular_todo();
            MessageBox.Show("El valor de cada cuota es de: "+p1.valor_cuota+ "\nEl monto total es de: " + p1.monto_total);
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
