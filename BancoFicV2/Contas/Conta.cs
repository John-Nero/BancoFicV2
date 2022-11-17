using System.Windows.Forms;

namespace BancoFicV2
{
    public abstract class Conta
    {
        
        public string Titular { get; set; }
        public int Numero { get; set; }
        public  Agencias Agencia { get; set; }
        public long Cpf { get; set; }
        public double Saldo { get; set; }
        public TipoDeConta Tipo { get; set; }

        public Conta() { }
        public Conta(string titular, Agencias agencia, int numero, long cpf, TipoDeConta tipo) { Titular = titular; Agencia = agencia; Numero = numero; Cpf = cpf; Tipo = tipo; }

        public void SetTipo(TipoDeConta tipo) { Tipo = tipo; }
        public void SetConta(string titular, Agencias agencia, int numero, long cpf, double saldo, TipoDeConta tipo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Cpf = cpf;
            Saldo = saldo;
            Tipo = tipo;
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
