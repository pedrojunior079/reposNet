using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06ClassesObjetos
{
    internal class Conta2
    {
        public int numero;
        public Cliente titular;
        public double saldo = 100.0;
            

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Deposita(double valor)
        {

        }     
    }

    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
    }
}
