using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            double horasTrabajadas = double.Parse(txtHorasTrabajadas.Text);
            double valorHora = double.Parse(txtValorHora.Text);
            double total = horasTrabajadas * valorHora;

            if (total>750000) {
                MessageBox.Show("El empleado gana mas del minimo");
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
            }
            else{
                total = (total * 0.20) + total;
                lblTotalSalario.Text = " $ " +Convert.ToDecimal(total).ToString("N0");
                lblTotalSalario.Visible = true;
            }
        }
    }
}
