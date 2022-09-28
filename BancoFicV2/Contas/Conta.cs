using System.Windows.Forms;

namespace BancoFicV2
{
    public abstract class Conta
    {
        public string Titular { get;  set; }
        public int Numero { get;  set; }
        public int Agencia { get;  set; }
        public decimal Cpf { get;  set; }
        public double Saldo { get;  set; }
        public int Id { get;  set; }

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
                MessageBox.Show("Saldo indisponivel",
                               "Saque não efetuado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.None);
            }
        }
    }
}
