

namespace BancoFicV2
{
    class ContaPoupanca : Conta
    {
        private double TaxaDeRentabilidade = 0.05;

        public ContaPoupanca() { }


        public ContaPoupanca(string titular, int numero,decimal cpf , double saldo) : base(titular, numero, cpf) { Saldo = saldo; }

        public double Render()
        {
            return Saldo * TaxaDeRentabilidade;
        }
    }
}
