using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if(saldo < 0.0)
            {
                MessageBox.Show("Voce está no negativo");
            }
            else if(saldo < 1000000.0)
            {
                MessageBox.Show("Voce é um bom cliente");
            }
            else
            {
                MessageBox.Show("Voce é milionário!");
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = 2;
            for(int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }
    }
}
