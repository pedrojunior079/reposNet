using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06ClassesObjetos
{
    internal class Conta
    {
        public int numero;
        public string titular;
        public double saldo = 100.0;

            

        public bool Saca(double valor)
        {
           if(this.saldo >= valor)
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
            this.saldo += valor;
        }
        
        public void Transfere(double valor, Conta destino)
        {
            if(this.Saca(valor))
            {
                destino.Deposita(valor);
            }     
        }     
    }
}
