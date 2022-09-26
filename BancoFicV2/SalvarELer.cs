using System;
using System.IO;
using System.Collections.Generic;


namespace BancoFicV2
{
    class SalvarELer
    {
        //ATENÇÃO Para o funcionamento correto do projeto é nescessario adaptar os caminhos dos arquivos.

        //Caminhos Para Local De Busca
        internal const string CaminhoPoupanca = @"C:\Users\john.barros\OneDrive - Clearsale S.A\Área de Trabalho\DadosDosClientesPoupanca.txt";
        internal const string CaminhoCorrente = @"C:\Users\john.barros\OneDrive - Clearsale S.A\Área de Trabalho\DadosDosClientesCorrente.txt";

        //Listas dos tipos de Conta
        public List<ContaPoupanca> LIstaDasPoupancas = new List<ContaPoupanca>();
        public List<ContaCorrente> LIstaDasCorrentes = new List<ContaCorrente>();

        //Metodos de Save e atualização da Conta Poupanca
        public List<ContaPoupanca> TxtParaPoupancas()
        {   //Nome | Agencia-Numero | CPF         | Saldo
            //john | 1-4578         | 12345678914 | 100
            try
            {
                string[] LeTexto = File.ReadAllLines(CaminhoPoupanca);
                foreach (string s in LeTexto)
                {
                    string[] ModeloInteiro = s.Split(" | ");
                    string[] AgenciaENumero = ModeloInteiro[1].Split("-");

                    string Titular = ModeloInteiro[0];
                    int Agencia = int.Parse(AgenciaENumero[0]);
                    int Numero = int.Parse(AgenciaENumero[1]);
                    decimal Cpf = decimal.Parse(ModeloInteiro[2]);
                    double Saldo = double.Parse(ModeloInteiro[3]);
                    LIstaDasPoupancas.Add(new ContaPoupanca(Titular, Agencia, Numero, Cpf, Saldo));
                }
                return LIstaDasPoupancas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void AtualizarContaPoupanca(ContaPoupanca Poupanca)
        {

            if (LIstaDasPoupancas.Count == 0)
            {
                TxtParaPoupancas();
            }
            foreach (ContaPoupanca Conta in LIstaDasPoupancas)
            {
                if (Poupanca.Agencia == Conta.Agencia && Poupanca.Numero == Conta.Numero)
                {
                    LIstaDasPoupancas.Remove(Conta);
                    break;
                }
            }

            using var file = File.AppendText(CaminhoPoupanca);
            LIstaDasPoupancas.Add(new ContaPoupanca(Poupanca.Titular,Poupanca.Agencia, Poupanca.Numero, Poupanca.Cpf, Poupanca.Saldo));
            file.Close();

            SalvarListaContaPoupancaNoTxt();
        }
        public void SalvarListaContaPoupancaNoTxt()
        {
            File.Delete(CaminhoPoupanca);

            using var file = File.AppendText(CaminhoPoupanca);

            foreach (ContaPoupanca Conta in LIstaDasPoupancas)
            {
                string titular = Conta.Titular;
                int agencia = Conta.Agencia;
                int numero = Conta.Numero;
                double saldo = Conta.Saldo;
                decimal cpf = Conta.Cpf;
                file.WriteLine($"{titular} | {agencia}-{numero} | {cpf} | {saldo.ToString("F2")}");
            }
            file.Close();
        }

        //Metodos de save e atualização da Conta corrente
        public List<ContaCorrente> TxtParaCorrentes()
        {   //Nome | Agencia-Numero | CPF         | Saldo | Limite
            //john | 1-4578         | 12345678914 | 100   | 500
            try
            {
                string[] LeTexto = File.ReadAllLines(CaminhoCorrente);
                if (LeTexto.Length != 0)
                {
                    foreach (string s in LeTexto)
                    {
                        string[] ModeloInteiro = s.Split(" | ");
                        string[] AgenciaENumero = ModeloInteiro[1].Split("-");

                        string Titular = ModeloInteiro[0];
                        int Agencia = int.Parse(AgenciaENumero[0]);
                        int Numero = int.Parse(AgenciaENumero[1]);
                        decimal Cpf = decimal.Parse(ModeloInteiro[2]);
                        double Saldo = double.Parse(ModeloInteiro[3]);
                        double Limite = double.Parse(ModeloInteiro[4]);
                        LIstaDasCorrentes.Add(new ContaCorrente(Titular, Agencia, Numero, Cpf, Saldo, Limite));
                    }
                }
                return LIstaDasCorrentes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void AtualizarContaCorrente(ContaCorrente Corrente)
        {

            if (LIstaDasCorrentes.Count == 0)
            {
                TxtParaCorrentes();
            }
            foreach (ContaCorrente Conta in LIstaDasCorrentes)
            {
                if (Corrente.Agencia == Conta.Agencia && Corrente.Numero == Conta.Numero)
                {
                    LIstaDasCorrentes.Remove(Conta);
                    break;
                }
            }

            using var file = File.AppendText(CaminhoCorrente);
            LIstaDasCorrentes.Add(new ContaCorrente(Corrente.Titular, Corrente.Agencia, Corrente.Numero, Corrente.Cpf, Corrente.Saldo,Corrente.LimiteEmprestimo));
            file.Close();

            SalvarListaContaCorrenteNoTxt();
        }
        public void SalvarListaContaCorrenteNoTxt()
        {
            File.Delete(CaminhoCorrente);

            using var file = File.AppendText(CaminhoCorrente);

            foreach (ContaCorrente Conta in LIstaDasCorrentes)
            {
                string titular = Conta.Titular;
                int agencia = Conta.Agencia;
                int numero = Conta.Numero;
                decimal cpf = Conta.Cpf;
                double saldo = Conta.Saldo;
                double limite = Conta.LimiteEmprestimo;
                file.WriteLine($"{titular} | {agencia}-{numero} | {cpf} | {saldo.ToString("F2")} | {limite}");
            }
            file.Close();
        }
    }
}
