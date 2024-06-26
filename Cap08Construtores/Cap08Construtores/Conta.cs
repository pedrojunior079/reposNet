using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap08Construtores
{
    internal class Conta
    {
        private int numero;
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        private double saldo;
        public double Saldo
        {
            get
            {
                return this.saldo;
            }

            set
            {
                this.saldo = value;
            }
        }

        private Cliente titular;

        public double PegaSaldo()
        {
            return this.saldo;
        }

        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    }

    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Cpf { get; set; }
        public string Rg { get; set; }

        // construtor que só recebe o nome
        public Cliente(string nome, string cpf, string rg)
        {
            this.Nome = nome;
            this.Cpf = Cpf;
            this.Rg = rg;
        }

        // construtor que recebe o nome e a idade
        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }     
        
    }     
}
