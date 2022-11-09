

namespace BancoFicV2
{
    class ContaPoupanca : Conta
    {
        private double TaxaDeRentabilidade = 0.05;

        public ContaPoupanca() { }


        public ContaPoupanca(string titular, Agencias agencia, int numero, long cpf, double saldo, TipoDeConta tipo) : base(titular, agencia, numero, cpf, tipo) { }

        public double Render(double saldo)
        {
            return saldo * TaxaDeRentabilidade;
        }
    }
}
