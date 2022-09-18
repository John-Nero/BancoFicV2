﻿using System;
using System.IO;
using System.Collections.Generic;


namespace BancoFicV2
{
    class SalvarELer
    {
        //Caminhos Para Local De Busca
        internal const string CaminhoPoupanca = @"C:\temp\Teste\BancoFicV2\BancoFicV2\DadosClientes\DadosDosClientesPoupanca.txt";
        internal const string CaminhoCorrente = @"C:\temp\Teste\BancoFicV2\BancoFicV2\DadosClientes\DadosDosClientesCorrente.txt";

        //Listas dos tipos de Conta
        public List<ContaPoupanca> LIstaDasPoupancas = new List<ContaPoupanca>();
        public List<ContaCorrente> LIstaDasCorrentes = new List<ContaCorrente>();

        //Metodos de Save e atualização da Conta Poupanca
        public List<ContaPoupanca> TxtParaPoupancas()
        {   //Nome | Numero | CPF         | Saldo
            //john | 4578   | 12345678914 | 100
            try
            {
                string[] LeTexto = File.ReadAllLines(CaminhoPoupanca);
                foreach (string s in LeTexto)
                {
                    string[] ModeloInteiro = s.Split(" | ");
                    LIstaDasPoupancas.Add(new ContaPoupanca(ModeloInteiro[0], int.Parse(ModeloInteiro[1]), decimal.Parse(ModeloInteiro[2]), double.Parse(ModeloInteiro[3])));
                    //2147483648
                      
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
                if (Poupanca.Cpf == Conta.Cpf && Poupanca.Numero == Conta.Numero)
                {
                    LIstaDasPoupancas.Remove(Conta);
                    break;
                }
            }

            using var file = File.AppendText(CaminhoPoupanca);
            LIstaDasPoupancas.Add(new ContaPoupanca(Poupanca.Titular, Poupanca.Numero, Poupanca.Cpf, Poupanca.Saldo));
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
                int numero = Conta.Numero;
                double saldo = Conta.Saldo;
                decimal cpf = Conta.Cpf;
                file.WriteLine($"{titular} | {numero} | {cpf} | {saldo.ToString("F2")}");
            }
            file.Close();
        }

        //Metodos de save e atualização da Conta corrente
        internal List<ContaCorrente> TxtParaCorrentes()
        {   //Nome | Numero | Cpf         | Saldo | Limite de emprestimo
            //john | 4578   | 12345678912 | 100   | 500
            try
            {
                string[] LeTexto = File.ReadAllLines(CaminhoCorrente);
                foreach (string s in LeTexto)
                {
                    string[] ModeloInteiro = s.Split(" | ");
                    LIstaDasCorrentes.Add(new ContaCorrente(ModeloInteiro[0], int.Parse(ModeloInteiro[1]), int.Parse(ModeloInteiro[2]), double.Parse(ModeloInteiro[3]), double.Parse(ModeloInteiro[4])));
                }
                return LIstaDasCorrentes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void AtualizarContaCorrente(ContaCorrente corrente)
        {
            if (LIstaDasCorrentes.Count == 0)
            {
                TxtParaPoupancas();
            }
            foreach (ContaCorrente Conta in LIstaDasCorrentes)
            {
                if (corrente.Titular == Conta.Titular && corrente.Numero == Conta.Numero)
                {
                    LIstaDasCorrentes.Remove(Conta);
                    break;
                }
            }

            using var file = File.AppendText(CaminhoCorrente);
            LIstaDasCorrentes.Add(new ContaCorrente(corrente.Titular, corrente.Numero, corrente.Cpf, corrente.Saldo, corrente.LimiteEmprestimo));
            file.Close();

            SalvarListaContaCorrenteNoTxt();
        }
        public void SalvarListaContaCorrenteNoTxt()
        {
            File.Delete(CaminhoCorrente);

            using var file = File.AppendText(CaminhoCorrente);

            foreach (ContaCorrente Conta in LIstaDasCorrentes)
            {
                file.WriteLine($"{Conta.Titular} | {Conta.Numero} | {Conta.Cpf} | {Conta.Saldo.ToString("F2")} | {Conta.LimiteEmprestimo}");
            }
            file.Close();
        }
    }
}
