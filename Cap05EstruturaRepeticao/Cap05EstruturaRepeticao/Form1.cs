using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap05EstruturaRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValorInvestidoFor_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            for(int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " +valorInvestido);
        }

        private void btnValorInvestidoWhile_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while(i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int total = 2;
            for(int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i<= 1000; i++)
            {
                soma = soma + i;
            }
            MessageBox.Show("A soma dos numeros de 1 até 1000 é: " + soma.ToString());
        }
    }
}
