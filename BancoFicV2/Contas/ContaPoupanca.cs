

namespace BancoFicV2
{
    class ContaPoupanca : Conta
    {
        private double TaxaDeRentabilidade = 0.05;

        public ContaPoupanca() { }


        public ContaPoupanca(string titular, int agencia, int numero, decimal cpf, double saldo, int id) : base(titular, agencia, numero, cpf, id) { Saldo = saldo; }

        public double Render(double saldo)
        {
            return saldo * TaxaDeRentabilidade;
        }
    }
}
