using System;
using System.Globalization;
using System.Windows.Forms;

namespace BancoFicV2
{
    public class ContaCorrente : Conta
    {
        public double LimiteEmprestimo { get; private set; } = 500;
        public ContaCorrente() { }

        public ContaCorrente(string titular, Agencias agencia, int numero, long cpf, TipoDeConta tipo, double saldo, double limite) : base(titular, agencia, numero, cpf, tipo) { Saldo = saldo; LimiteEmprestimo = limite; }



        public void SetLimitEmprestimo(double limite)
        {
            LimiteEmprestimo = limite;
        }
        public void SolicitarEmprestimo(double valor)
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
                MessageBox.Show("Saldo indisponivel",
                               "Saque não efetuado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
            }
        }
    }
}
