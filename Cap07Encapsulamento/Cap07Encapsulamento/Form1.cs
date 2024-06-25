using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap07Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncapsulamento_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.ColocaNumero(1100);
            MessageBox.Show("Saldo: " + conta.PegaSaldo());


            Conta c = new Conta();
            c.Numero = 1; // funciona pois o set do Numero é público
            MessageBox.Show("Numero: " + c.Numero);

            c.Saldo = 100.0; // set do saldo é privado, então temos um erro
            MessageBox.Show("Saldo " + c.Saldo); // funciona pois o get do saldo é publico.
            

        }
    }
}
