using System;

namespace BancoFicV2
{
    public abstract class Conta
    {
        public string Titular { get; internal set; }
        public int Numero { get; internal set; }
        public int Agencia { get; internal set; }
        public decimal Cpf { get; internal set; }
        public double Saldo { get; internal set; }
        public int Id { get; internal set; }

        public Conta() { }
        public Conta(string titular, int agencia, int numero, decimal cpf) { Titular = titular; Agencia = agencia; Numero = numero; Cpf = cpf; }

        public void SetId(int id) { Id = id; }
        public  void SetConta(string titular, int agencia, int numero, decimal cpf, double saldo, int id)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Cpf = cpf;
            Saldo = saldo;
            Id = id;
        }
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
