using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07Encapsulamento
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

    }     
}
