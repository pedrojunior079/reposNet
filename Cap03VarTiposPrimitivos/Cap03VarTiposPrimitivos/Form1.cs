using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap03VarTiposPrimitivos
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
            double valorDoSaque = 10.0;
            saldo = saldo - valorDoSaque;
            MessageBox.Show("O Saldo dsa conta apos o saque é: " + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Minha Mensagem";
            MessageBox.Show(mensagem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensagem = "Olá";
            string nome = "Victor";
            MessageBox.Show(mensagem + nome);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idade = 25;
            string mensagem = "Sua idade é: " + idade;

            MessageBox.Show(mensagem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }
    }
}
