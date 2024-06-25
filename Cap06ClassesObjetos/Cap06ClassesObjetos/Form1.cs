using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap06ClassesObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";


            // inicialização da conta
            Conta victor = new Conta();
            victor.saldo = 1000;

            // incialização da conta
            Conta guilherme = new Conta();

            // Agora vamos transferir o dinheiro da conta do victor para a do guilherme
            victor.Transfere(10.0, guilherme);


            // Inicializa as informações da conta
            c.saldo = 100.0;

            // Agora chama o método Saca que foi definido na classe
            c.Saca(10.0);

            c.Deposita(100.0);

            // inicializa os atributos

            // Se a conta tiver saldo suficinte, deuCerto conterá o valor true
            // senão, ela conterá false
            bool deuCerto = c.Saca(100.0);
            if(deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }     
        }

        private void btnConta2_Click(object sender, EventArgs e)
        {
            Conta2 contaVictor = new Conta2();
            contaVictor.titular.nome = "Victor";
            contaVictor.numero = 1;
            contaVictor.Deposita(100);
            MessageBox.Show("Saldo: " +contaVictor.saldo);
            contaVictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);

            Conta2 mauricio = new Conta2();
            mauricio.saldo = 2000.0;

            Conta2 guilherme = new Conta2();
            guilherme.saldo = 5000.0;
            
            mauricio.saldo -= 200.0;
            guilherme.saldo += 200.0;

            MessageBox.Show("Mauricio = " + mauricio.saldo);
            MessageBox.Show("Guilherme = " + guilherme.saldo);
        }

        private void btnExercicio9_Click(object sender, EventArgs e)
        {
            //Conta2 mauricio = new Conta2();
            Cliente mauricio = new Cliente();
           
            mauricio.nome = "Mauricio";

            Conta2 umaConta = new Conta2();
            umaConta.titular = mauricio;


            Cliente mauricio2 = new Cliente();

            mauricio2.nome = "Mauricio 2";

            Conta2 umaConta2 = new Conta2();
            umaConta2.titular = mauricio2;

            
            if(mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void btnExercicio10_Click(object sender, EventArgs e)
        {
            Conta2 mauricio = new Conta2();
            mauricio.saldo = 2000.0;
            Conta2 copia = mauricio;
            copia.saldo = 3000.0;
            MessageBox.Show("Mauricio = " + mauricio.saldo);
            MessageBox.Show("Copia = " + copia.saldo);
        }

        private void btnCompClasses_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            victor.nome = "Victor";
            Conta2 umaConta = new Conta2();
            umaConta.titular = victor;

            umaConta.titular.rg = "12345678-9";

            // Mostra o nome victor
            MessageBox.Show(umaConta.titular.nome);

            // Mostra o texto 12345678-9
            MessageBox.Show(victor.rg);
        }
    }
}
