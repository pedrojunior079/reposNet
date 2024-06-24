using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap04EstruturaControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo = saldo - valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }     
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque reslizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }     
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque reslizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if(saldo < 0.0)
            {
                MessageBox.Show("Voce está no negativo");
            }
            else if(saldo > 1000000.0)
            {
                MessageBox.Show("Voce é um bom cliente");
            }
            else
            {
                MessageBox.Show("Voce é milionario");
            }     
        }

        private void btnValorDaNotaFiscal_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 5000.0;
            double imposto = 0.0;

            if(valorDaNotaFiscal <= 999)
            {
                imposto = valorDaNotaFiscal * 0.02;
            }
            else if(valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
            {
                imposto = valorDaNotaFiscal * 0.028;
            }
            else if(valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                imposto = valorDaNotaFiscal * 0.028;
            }
            else if(valorDaNotaFiscal >= 7000)
            {
                imposto = valorDaNotaFiscal * 0.03;
            }

            MessageBox.Show("O imposto calculado é: " + imposto.ToString("C"));
        }
    }
}
