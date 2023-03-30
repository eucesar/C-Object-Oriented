using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//eu crio uma class para interlegar outros .cs = td PUBLIC 
//separar variavel
namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }


        public string Conta { get; set; }
        //eu privei so nesse codigo
        private double saldo = 100;

        //cliquei na lampada pq poem no altomatico = Ttilar.Cliente
        public Cliente titular;

        public void Depositar(double valor) //vou definir o valor dentro do 'Depositar' fora do class
        {
            saldo += valor;
        }

        //boll = condicionalA
        public bool Sacar(double valor)
        {
            if (valor <= saldo) //tem q ser manor ou igual ao valor para poder sacar
            {
                saldo -= valor; //se tiver saldo - o valor do saque for menor ou igual = pq preciso de dinheiro para sacar, n pode ser maior q o valor - pq dai n tenho dinheiro
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor) //se o saldo que eu quer transferir for menor que o valor tt da conta
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        //SET = alterar
        //GET = pegar
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }
    }

}
