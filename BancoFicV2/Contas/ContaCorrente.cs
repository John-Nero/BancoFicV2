using System;
using System.Globalization;

namespace BancoFicV2
{
    public class ContaCorrente : Conta
    {
        public double LimiteEmprestimo { get; private set; } = 500;
        public ContaCorrente() { }

        public ContaCorrente(string titular,int agencia, int numero,decimal cpf, double saldo, double limite) : base(titular,agencia, numero,cpf) { Saldo = saldo; LimiteEmprestimo = limite; }
        
            
        
        public void SetLimitEmprestimo(double limite)
        {
            LimiteEmprestimo = limite;
        }
        public  void SolicitarEmprestimo(double valor)
        {
                Depositar(valor);
                Console.WriteLine(" Saldo atualizado: ");
                Console.WriteLine($" Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)} \n");
                LimiteEmprestimo -= valor;
        }
        public override void Sacar(double valor)
        {
            if (Saldo >= valor + 5 && valor > 0)
            {
                Saldo -= valor + 5;
            }
            else
            {
                Console.WriteLine("SALDO INDISPONIVEL PARA OPERAÇÂO");
            }

        }
        
    }
}
