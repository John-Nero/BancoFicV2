using System;

namespace BancoFicV2
{
    class Conta
    {
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public decimal Cpf { get; private set; }
        public double Saldo { get; internal set; }

        public Conta() { }
        public Conta(string titular, int numero, decimal cpf) { Titular = titular; Numero = numero; Cpf = cpf; }

        public void setNumero(int numero) { Numero = numero; }

        public void setTitular(string titular) { Titular = titular; }

        public void setCpf(decimal cpf) { Cpf = cpf; }

        public void Depositar(double valor) { Saldo += valor; }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("SALDO INDISPONIVEL PARA OPERAÇÂO");
            }
        }
    }
}
