using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cap10Heranca.Conta;

namespace Cap10Heranca
{
    public class ContaPoupanca : Conta
    {
        public int Numero { get; set; } 
        public double Saldo { get; set; }

        public Cliente Titular { get; set; }

        // Estamos chamando o construtor da classe pai já faz a inicialização
        // do número e por isso o corpo do cunstrutor pode ficar vazio
        public ContaPoupanca(int numero)
        {
            this.Numero = numero;
        }


        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10);
        }

        // Código do formulario da aplicação
        ContaPoupanca c = new ContaPoupanca();

        // chama o compoetamento escrito no pai
        // O Saldo termina em 100.0 depois dessa linha
        conta.Saca(50);

        Conta conta = new Conta();
        conta.Deposita(100.0); 
            
        

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void CalculaRendimento()
        {
            
        }     
    }

    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }

        public void Soma(ContaPoupanca conta)
        {

        }

        public void Soma(ContaEstudante conta)
        {

        }
    }

    Conta c1 = new Conta();
    ContaPoupanca c2 = new ContaPoupanca();

    TotalizadorDeContas t = new TotalizadorDeContas();
    t.Soma(c1);
    t.Soma(c2);     
}
