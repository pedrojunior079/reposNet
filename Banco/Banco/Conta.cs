using System;

namespace Banco
{
    internal class Conta
    {
        public int Numero { get; internal set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }

        public Conta()
        {
            
        }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }     
    }
}